/*
 * Created Date: 2022-08-04 (Thu)
 * Author: Doyun Jung (정도윤) / rabbit.white@daum.net
 * Subject: BarcodeQRRecognizeFrm
 * Filename: BarcodeQRRecognizeFrm.cs
 * Description:
 * 
 * 
 * 
 */
using OpenCvSharp;
using OpenCvSharp.Extensions;
using SmartLogistics.model;
using SmartLogistics.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;

namespace SmartLogistics
{
    public partial class BarcodeQRRecognizeFrm : Form
    {
        // 델리게이트 생성 (쓰레드에서 프로그래스 접근을 위함)
        delegate void myDelegate(string message);

        bool isCameraOn;

        Thread thread;
        Mat mat;
        Mat destMat;
        VideoCapture videoCapture;
        String decoded;

        public BarcodeQRRecognizeFrm()
        {
            InitializeComponent(); 
            
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            thread = null;
            mat = null;
            destMat = null;
            videoCapture = null;

            isCameraOn = false;

            panel_result.BackColor = Color.Transparent;
            lbl_result_print.Text = "초기 시작";

        }

        private void CameraCallback()
        {

            mat = new Mat(); 

            videoCapture = new VideoCapture(0);
            videoCapture.Set(VideoCaptureProperties.FrameWidth, 640);
            videoCapture.Set(VideoCaptureProperties.FrameHeight, 480);
            BarcodeReader reader = new BarcodeReader();


            if (!videoCapture.IsOpened())
            {
                MessageBox.Show("Camera open failed");
            }

            while (isCameraOn)
            {
                try
                {
                    videoCapture.Read(mat);

                    // n차원 행렬이 비어있을 때
                    if (mat.Empty())
                    {
                        break;
                    }

                    destMat = mat;

                    // Gaussian 필터 적용
                    Cv2.GaussianBlur(mat, destMat, new OpenCvSharp.Size(), (double)1);

                    // 언샤프 마스크 필터 적용
                    float alpha = 1f;
                    destMat = (1 + alpha) * mat - alpha * destMat;

                    // 메모리 스트림 방식 
                    System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(destMat.ToBytes());

                    // 메모리 누수 버그 방지
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                    }

                    // 메모리 스트림 방식
                    pictureBox1.Image = new Bitmap(memoryStream);

                    // 메모리 누수 발생(비추천)
                    //pictureBox1.Image = BitmapConverter.ToBitmap(destMat);

                    //cheesePhoto();

                    string tmp = detectBarcode(mat, thresh: 170, debug: false);

                    // 델리게이트호출
                    this.Invoke(new myDelegate(updateBarcode), new object[] { tmp });
                    Thread.Sleep(10);

                    /*
                    //Result result = reader.Decode((Bitmap)pictureBox1.Image);
                    Result result = reader.Decode((Bitmap)BitmapConverter.ToBitmap(mat));

                    if (result != null)
                    {
                        decoded = "Decode : " + result.ToString() + "\r\nType : " + result.BarcodeFormat.ToString();
                        if (decoded != "")
                        {
                            textBox1.Text = decoded;
                        }
                    }
                    else {
                        //MessageBox.Show("바코드나 QR코드를 비추세요!");
                        //textBox1.Text = "";
                    }*/

                }
                catch (Exception ex)
                {

                }

                Cv2.DestroyAllWindows();

            }

        }


        // 바코드 변경
        private void updateBarcode(String message)
        {
            txtBarcode.Text = message;
            //txtBarcode.Text = txtBarcode.Text + message;
            obtain_product(message);
        }

        private void obtain_product(String barcode)
        {
            ProductVO productVO = new ProductVO();
            WarehouseVO warehouseVO = new WarehouseVO();
            WarehouseLogVO warehouseLogVO = new WarehouseLogVO();
            WarehouseBarcodeVO warehouseBarcodeVO = new WarehouseBarcodeVO();
            ProductBoxSpecVO productBoxSpecVO = new ProductBoxSpecVO();
            ProductBarcodeVO productBarcodeVO = new ProductBarcodeVO();

            warehouseBarcodeVO.rand_id = barcode;

            IWarehouseBarcodeService warehouseBarcodeService = new WarehouseBarcodeService();
            DataSet ds = warehouseBarcodeService.SelectWarehouseBarcodeFindRandId(warehouseBarcodeVO);

            // 창고 바코드 정보 데이터셋 가져오기
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                //Console.WriteLine(r["Name"]);
                warehouseBarcodeVO.id = int.Parse(r["id"].ToString());
                warehouseBarcodeVO.rand_id = r["rand_id"].ToString();
                warehouseBarcodeVO.regidate = ((DateTime)r["regidate"]).ToString("yyyy-MM-dd HH:mm:ss");
                warehouseBarcodeVO.ip = r["ip"].ToString();

            }

            // 창고 정보
            warehouseVO.id = warehouseBarcodeVO.id;
            IWarehouseService warehouseService = new WarehouseService();

            ds = warehouseService.SelectWarehouseFindId(warehouseVO);

            // 창고 바코드 정보 데이터셋 가져오기
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                //Console.WriteLine(r["Name"]);
                warehouseVO.id = int.Parse(r["id"].ToString());
                warehouseVO.product_id = int.Parse(r["product_id"].ToString());
                warehouseVO.product_cnt = int.Parse(r["product_cnt"].ToString());
                warehouseVO.create_date = ((DateTime)r["create_date"]).ToString("yyyy-MM-dd HH:mm:ss");
                warehouseVO.create_type = r["create_type"].ToString();
                warehouseVO.ip = r["ip"].ToString();

            }

            productVO.product_id = warehouseVO.product_id;
            productBarcodeVO.product_id = warehouseVO.product_id;
            IProductService productService = new ProductService();

            ds = productService.SelectProductFindID(productVO);

            // 제품 바코드 가져오기
            if (productService.SelectProductBarcodeFindId(productBarcodeVO) != null)
            {
                productBarcodeVO = productService.SelectProductBarcodeFindId(productBarcodeVO);
            }
            else
            {
                productBarcodeVO.product_id = 0;
                productBarcodeVO.rand_id = "";
                productBarcodeVO.regidate = "";
                productBarcodeVO.ip = "";
            }

            // 제품 정보 데이터셋 가져오기
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                productVO.product_id = int.Parse(r["product_id"].ToString());
                productVO.product_name = r["product_name"].ToString();
                productVO.description = r["Description"].ToString();
                productVO.regidate = ((DateTime)r["regidate"]).ToString("yyyy-MM-dd HH:mm:ss");
                productVO.ip = r["ip"].ToString();
                productVO.project_id = int.Parse(r["project_id"].ToString());

            }

            ds = warehouseService.SelectLatestWarehouseLogFindWid(warehouseVO);

            // 창고 수량 데이터셋 가져오기
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                warehouseLogVO.id = int.Parse(r["id"].ToString());
                warehouseLogVO.w_id = int.Parse(r["w_id"].ToString());
                warehouseLogVO.prev_w_id = int.Parse(r["prev_w_id"].ToString());
                warehouseLogVO.prev_cnt = int.Parse(r["prev_cnt"].ToString());
                warehouseLogVO.release_cnt = int.Parse(r["release_cnt"].ToString());
                warehouseLogVO.current_cnt = int.Parse(r["current_cnt"].ToString());
                warehouseLogVO.current_type = r["current_type"].ToString();
                warehouseLogVO.release_type = r["release_type"].ToString();
                warehouseLogVO.release_date = ((DateTime)r["release_date"]).ToString("yyyy-MM-dd HH:mm:ss");
                warehouseLogVO.ip = r["ip"].ToString();

            }

            ds = productService.SelectProductBoxSpecFindProductID(productVO);

            // 박스 형태 데이터셋 가져오기
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                productBoxSpecVO.product_id = int.Parse(r["product_id"].ToString());
                productBoxSpecVO.box_type_id = int.Parse(r["box_type_id"].ToString());
                productBoxSpecVO.type_name = r["type_name"].ToString();
                productBoxSpecVO.width = int.Parse(r["width"].ToString());
                productBoxSpecVO.length = int.Parse(r["length"].ToString());
                productBoxSpecVO.height = int.Parse(r["height"].ToString());
                productBoxSpecVO.box_name = r["box_name"].ToString();
                productBoxSpecVO.regidate = ((DateTime)r["regidate"]).ToString("yyyy-MM-dd HH:mm:ss");
                productBoxSpecVO.ip = r["ip"].ToString();
            }

            // 제품 정보 필드 채우기
            txtProduct_barcode_qr.Text = productBarcodeVO.rand_id;
            txtProduct_name.Text = productVO.product_name;
            txtProduct_regidate.Text = warehouseVO.create_date;

            // 상자 정보 필드 채우기
            txtBoxspec_type_name.Text = productBoxSpecVO.type_name;
            txtBoxspec_width.Text = productBoxSpecVO.width.ToString();
            txtBoxspec_length.Text = productBoxSpecVO.length.ToString();
            txtBoxspec_height.Text = productBoxSpecVO.height.ToString();
            txtBoxspec_boxname.Text = productBoxSpecVO.box_name;

            // 현재 제품 재고 채우기
            txtWarehouse_barcode_qr.Text = warehouseBarcodeVO.rand_id;
            txtWarehouse_current_cnt.Text = warehouseLogVO.current_cnt.ToString();
            txtWarehouse_regidate.Text = warehouseLogVO.release_date;

            // 현황판 출력
            if ( txtProduct_barcode_qr.Text.Length > 0)
            {
                panel_result.BackColor = Color.LightGreen;
                lbl_result_print.Text = "정상";
            }
            else
            {
                panel_result.BackColor = Color.LightPink;
                lbl_result_print.Text = "실패";
            }

        }

        private void BarcodeTest_Load(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(CameraCallback));

            thread.Start();
            isCameraOn = true;

        }

        private void BarcodeTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 카메라 종료
            cameraClosed();

            // Process Kill
            System.Diagnostics.Process[] mProcess = System.Diagnostics.Process.GetProcessesByName(Application.ProductName);
            foreach (System.Diagnostics.Process p in mProcess)
                p.Kill();
        }

        private static void rotateImage(Mat src, Mat dst, double angle, double scale)
        {
            var imageCenter = new Point2f(src.Cols / 2f, src.Rows / 2f);
            var rotationMat = Cv2.GetRotationMatrix2D(imageCenter, angle, scale);
            Cv2.WarpAffine(src, dst, rotationMat, src.Size());
        }

        private static string detectBarcode(Mat destMat, double thresh, bool debug = false, double rotation = 0)
        {

            // load the image and convert it to grayscale
            //var image = new Mat(fileName);
            var image = destMat;

            if (rotation != 0)
            {
                rotateImage(image, image, rotation, 1);
            }
/*
            if (debug)
            {
                Cv2.ImShow("Source", image);
                Cv2.WaitKey(1); // do events
            }
*/
            var gray = new Mat();
            var channels = image.Channels();
            if (channels > 1)
            {
                Cv2.CvtColor(image, gray, ColorConversionCodes.BGRA2GRAY);
            }
            else
            {
                image.CopyTo(gray);
            }


            // compute the Scharr gradient magnitude representation of the images
            // in both the x and y direction
            var gradX = new Mat();
            Cv2.Sobel(gray, gradX, MatType.CV_32F, xorder: 1, yorder: 0, ksize: -1);
            //Cv2.Scharr(gray, gradX, MatType.CV_32F, xorder: 1, yorder: 0);

            var gradY = new Mat();
            Cv2.Sobel(gray, gradY, MatType.CV_32F, xorder: 0, yorder: 1, ksize: -1);
            //Cv2.Scharr(gray, gradY, MatType.CV_32F, xorder: 0, yorder: 1);

            // subtract the y-gradient from the x-gradient
            var gradient = new Mat();
            Cv2.Subtract(gradX, gradY, gradient);
            Cv2.ConvertScaleAbs(gradient, gradient);
/*
            if (debug)
            {
                Cv2.ImShow("Gradient", gradient);
                Cv2.WaitKey(1); // do events
            }*/


            // blur and threshold the image
            var blurred = new Mat();
            Cv2.Blur(gradient, blurred, new OpenCvSharp.Size(9, 9));

            var threshImage = new Mat();
            Cv2.Threshold(blurred, threshImage, thresh, 255, ThresholdTypes.Binary);
/*
            if (debug)
            {
                Cv2.ImShow("Thresh", threshImage);
                Cv2.WaitKey(1); // do events
            }
*/

            // construct a closing kernel and apply it to the thresholded image
            var kernel = Cv2.GetStructuringElement(MorphShapes.Rect, new OpenCvSharp.Size(21, 7));
            var closed = new Mat();
            Cv2.MorphologyEx(threshImage, closed, MorphTypes.Close, kernel);
/*
            if (debug)
            {
                Cv2.ImShow("Closed", closed);
                Cv2.WaitKey(1); // do events
            }*/


            // perform a series of erosions and dilations
            Cv2.Erode(closed, closed, null, iterations: 4);
            Cv2.Dilate(closed, closed, null, iterations: 4);
/*
            if (debug)
            {
                Cv2.ImShow("Erode & Dilate", closed);
                Cv2.WaitKey(1); // do events
            }*/


            //find the contours in the thresholded image, then sort the contours
            //by their area, keeping only the largest one

            OpenCvSharp.Point[][] contours;
            HierarchyIndex[] hierarchyIndexes;
            Cv2.FindContours(
                closed,
                out contours,
                out hierarchyIndexes,
                mode: RetrievalModes.CComp,
                method: ContourApproximationModes.ApproxSimple);

            if (contours.Length == 0)
            {
                throw new NotSupportedException("Couldn't find any object in the image.");
            }

            var contourIndex = 0;
            var previousArea = 0;
            var biggestContourRect = Cv2.BoundingRect(contours[0]);
            while ((contourIndex >= 0))
            {
                var contour = contours[contourIndex];

                var boundingRect = Cv2.BoundingRect(contour); //Find bounding rect for each contour
                var boundingRectArea = boundingRect.Width * boundingRect.Height;
                if (boundingRectArea > previousArea)
                {
                    biggestContourRect = boundingRect;
                    previousArea = boundingRectArea;
                }

                contourIndex = hierarchyIndexes[contourIndex].Next;
            }


            /*biggestContourRect.Width += 10;
            biggestContourRect.Height += 10;
            biggestContourRect.Left -= 5;
            biggestContourRect.Top -= 5;*/


            var barcode = new Mat(image, biggestContourRect); //Crop the image
            Cv2.CvtColor(barcode, barcode, ColorConversionCodes.BGRA2GRAY);

            /*Cv2.ImShow("Barcode", barcode);
            Cv2.WaitKey(1); // do events*/

            var barcodeClone = barcode.Clone();
            var barcodeText = getBarcodeText(barcodeClone);

            if (string.IsNullOrWhiteSpace(barcodeText))
            {
                Console.WriteLine("Enhancing the barcode...");
                //Cv2.AdaptiveThreshold(barcode, barcode, 255,
                //AdaptiveThresholdType.GaussianC, ThresholdType.Binary, 9, 1);
                //var th = 119;
                var th = 100;
                Cv2.Threshold(barcode, barcode, th, 255, ThresholdTypes.Tozero);
                Cv2.Threshold(barcode, barcode, th, 255, ThresholdTypes.Binary);
                barcodeText = getBarcodeText(barcode);
            }

            Cv2.Rectangle(image,
                new OpenCvSharp.Point(biggestContourRect.X, biggestContourRect.Y),
                new OpenCvSharp.Point(biggestContourRect.X + biggestContourRect.Width, biggestContourRect.Y + biggestContourRect.Height),
                new Scalar(0, 255, 0),
                2);
            /*
                        if (debug)
                        {
                            Cv2.ImShow("Segmented Source", image);
                            Cv2.WaitKey(1); // do events
                        }*/
            /*
                        Cv2.WaitKey(0);
                        Cv2.DestroyAllWindows();*/

            return barcodeText;
        }

        private static string getBarcodeText(Mat barcode)
        {
            // `ZXing.Net` needs a white space around the barcode
            var barcodeWithWhiteSpace = new Mat(new OpenCvSharp.Size(barcode.Width + 30, barcode.Height + 30), MatType.CV_8U, Scalar.White);
            var drawingRect = new Rect(new OpenCvSharp.Point(15, 15), new OpenCvSharp.Size(barcode.Width, barcode.Height));
            var roi = barcodeWithWhiteSpace[drawingRect];
            barcode.CopyTo(roi);/*

            Cv2.ImShow("Enhanced Barcode", barcodeWithWhiteSpace);
            Cv2.WaitKey(1); // do events*/

            return decodeBarcodeText(barcodeWithWhiteSpace.ToBitmap());
        }

        private static string decodeBarcodeText(System.Drawing.Bitmap barcodeBitmap)
        {
            var source = new BitmapLuminanceSource(barcodeBitmap);

            // using http://zxingnet.codeplex.com/
            // PM> Install-Package ZXing.Net
            var reader = new BarcodeReader(null, null, ls => new GlobalHistogramBinarizer(ls))
            {
                AutoRotate = true,
                TryInverted = true,
                Options = new DecodingOptions
                {
                    TryHarder = true,
                    //PureBarcode = true,
                    /*PossibleFormats = new List<BarcodeFormat>
                    {
                        BarcodeFormat.CODE_128
                        //BarcodeFormat.EAN_8,
                        //BarcodeFormat.CODE_39,
                        //BarcodeFormat.UPC_A
                    }*/
                }
            };

            //var newhint = new KeyValuePair<DecodeHintType, object>(DecodeHintType.ALLOWED_EAN_EXTENSIONS, new Object());
            //reader.Options.Hints.Add(newhint);

            var result = reader.Decode(source);
            if (result == null)
            {
                Console.WriteLine("Decode failed.");
                return string.Empty;
            }

            Console.WriteLine("BarcodeFormat: {0}", result.BarcodeFormat);
            Console.WriteLine("Result: {0}", result.Text);
            

            var writer = new BarcodeWriter
            {
                Format = result.BarcodeFormat,
                Options = { Width = 200, Height = 50, Margin = 4 },
                Renderer = new ZXing.Rendering.BitmapRenderer()
            };
            var barcodeImage = writer.Write(result.Text);/*
            Cv2.ImShow("BarcodeWriter", barcodeImage.ToMat());*/

            return result.Text;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            FaMainFrm frm = new FaMainFrm();
            frm.Show();
            this.Hide();

            cameraClosed();

        }

        private void cameraClosed()
        {

            isCameraOn = false;

            if (thread != null &&
                thread.IsAlive &&
                videoCapture != null)
            {
                if (videoCapture.IsOpened())
                {
                    videoCapture.Release();
                    if (mat != null)
                    {
                        mat.Dispose();
                    }

                    if (destMat != null)
                    {
                        destMat.Dispose();
                    }

                    thread.Interrupt();

                }

            }

        }


    }

}
