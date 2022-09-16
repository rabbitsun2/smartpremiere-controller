/*
 * Created Date: 2022-06-29 (Wed)
 * Author: Doyun Jung (정도윤) / rabbit.white@daum.net
 * Subject: ProductCameraCapture
 * Filename: ProductCameraCaptureFrm.cs
 * Description:
 * - 1. 문자열 전송 기능 구현, 정도윤, 2022-07-19 (Tue)
 * - 2. 카메라 종료 처리 버그 개선, 정도윤, 2022-08-01 (Mon)
 * - 3. 프로세스 종료 시 전체 프로세스 탐색 후 종료 처리, 2022-08-09 (Tue)
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using System.Threading;
using SmartLogistics.model;
using SmartLogistics.service;

namespace SmartLogistics
{
    public partial class ProductCameraCaptureFrm : Form
    {
        bool isCameraOn;
        bool isZoomUp;

        Thread thread;
        Mat mat;
        Mat destMat;
        VideoCapture videoCapture;

        IProductService productService;

        public ProductCameraCaptureFrm(string recvData)
        {
            InitializeComponent();

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            isCameraOn = false;

            // 데이터 값 가져오기
            string tmp = recvData.Substring(0, recvData.IndexOf("/"));
            txtProjectId.Text = tmp;
            recvData = recvData.Replace(tmp + "/", "");
            tmp = recvData.Substring(0, recvData.IndexOf("/"));

            txtProjectName.Text = tmp;
            recvData = recvData.Replace(tmp + "/", "");
            tmp = recvData.Substring(0, recvData.IndexOf(","));

            txtProductName.Text = tmp;
            recvData = recvData.Replace(tmp + ",", "");
            tmp = recvData.Substring(0, recvData.IndexOf("/"));

            txtDescription.Text = tmp;

            // UUID 생성 (예비)
            Guid myUUId = Guid.NewGuid();
            string convertedUUID = myUUId.ToString();
            lblTxtUUID.Text = convertedUUID;

            // 다음 메뉴 숨기기
            btnNext.Enabled = false;

            // 서비스 생성
            productService = new ProductService();

            // 키 단축키
            KeyPreview = true;

            // 줌
            isZoomUp = false;

        }
        private void ProductCameraCaptureFrm_Load(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(CameraCallback));

            thread.Start();
            isCameraOn = true;
        }

        private void CameraCallback()
        {
            mat = new Mat();
            videoCapture = new VideoCapture(0);
            videoCapture.Set(VideoCaptureProperties.FrameWidth, 640);
            videoCapture.Set(VideoCaptureProperties.FrameHeight, 480);

            if (!videoCapture.IsOpened())
            {
                MessageBox.Show("카메라를 열지 못했습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            while (isCameraOn)
            {
                try
                {
                    videoCapture.Read(mat);

                    // n차원 행렬이 비어있을 때
                    if (mat.Empty())
                        break;

                    destMat = mat;

                    // Gaussian 필터 적용
                    Cv2.GaussianBlur(mat, destMat, new OpenCvSharp.Size(), (double)1);

                    // 언샤프 마스크 필터 적용
                    float alpha = 1f;
                    destMat = (1 + alpha) * mat - alpha * destMat;

                    // ImShow 실행하기
                    if (isZoomUp == true)
                    {
                        //OpenCvSharp.Size size = new OpenCvSharp.Size(mat.Width * 2, mat.Height * 2);
                        //Cv2.Resize(mat, destMat, size);

                        Cv2.ImShow("dst1", destMat);

                        DialogResult msgResult = MessageBox.Show("실제 촬영된 화질입니다. 괜찮으신가요?", "YesOrNo",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (msgResult == DialogResult.Yes)
                        {
                            isZoomUp = false;
                        }

                    }

                    System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(mat.ToBytes());

                    // 메모리 누수 버그 방지
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                    }

                    pictureBox1.Image = new Bitmap(memoryStream);
                    

                }
                catch (Exception ex)
                {

                }

            }

            Cv2.DestroyAllWindows();
        }


        private void ProductCameraCaptureFrm_FormClosing(object sender, FormClosingEventArgs e)
        {

            cameraClosed();

            // Process Kill
            System.Diagnostics.Process[] mProcess = System.Diagnostics.Process.GetProcessesByName(Application.ProductName);
            foreach (System.Diagnostics.Process p in mProcess)
                p.Kill();

        }


        private void ProductCameraCaptureFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.C)
            {
                cheesePhoto();
            }
            else if (e.Control && e.KeyCode == Keys.P)
            {
                prevFrm();
            }
            else if (e.Control && e.KeyCode == Keys.Z)
            {
                zoom_up();
            }

        }

        private void cheesePhoto()
        {

            int startnum = int.Parse(lblStartNum.Text);
            int endnum = int.Parse(lblEndNum.Text);
            startnum++;

            if (startnum > endnum)
            {
                btnNext.Enabled = true;
                MessageBox.Show("다음 메뉴를 눌러서 진행하세요.", "확인",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }

            if (thread != null &&
                thread.IsAlive &&
                videoCapture != null)
            {
                if (videoCapture.IsOpened())
                {

                    lblStartNum.Text = startnum.ToString();

                    string myPath = setting.SMConfig.GetSmartLogisticsDir();
                    string myTrain = myPath + "/train";
                    string realFullPath = myTrain + "/" + lblTxtUUID.Text;

                    // 루트 경로
                    if (!Directory.Exists(myPath))
                    {
                        Directory.CreateDirectory(myPath);
                    }

                    // Train 경로(학습)
                    if (!Directory.Exists(myTrain))
                    {
                        Directory.CreateDirectory(myTrain);
                    }

                    // 임시 UUID 폴더
                    if (!Directory.Exists(realFullPath))
                    {
                        Directory.CreateDirectory(realFullPath);
                    }

                    string save = DateTime.Now.ToString("yyyyMMdd-HHmmss-" + startnum);

                    try
                    {
                        Cv2.ImWrite(realFullPath + "/" + save + ".jpg", mat);

                    }catch(Exception e)
                    {
                        MessageBox.Show(e.Message, "확인", MessageBoxButtons.OK, 
                                                            MessageBoxIcon.Information);
                    }
                }

            }
            else
            {
                startnum--;
                lblStartNum.Text = startnum.ToString();

                MessageBox.Show("카메라가 초기화되지 않았습니다.", "확인",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

        }

        private void btnCheese_Click(object sender, EventArgs e)
        {
            cheesePhoto();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            isCameraOn = false;

            // 카메라 종료
            cameraClosed();

            // DB 등록
            registerDBdata();

            // 데이터 값 전송
            string sendData = txtProjectId.Text + "/" + txtProjectName.Text + "/";
            sendData += txtProductName.Text + "/" + txtDescription.Text + "/";

            // 폼 이동
            ProductRegisterSuccessFrm frm = new ProductRegisterSuccessFrm(sendData);
            frm.Show();
            this.Hide();


        }

        private void registerDBdata()
        {

            bool status_rand_id = true;

            string myPath = setting.SMConfig.GetSmartLogisticsDir();
            string myTrain = myPath + "/train";
            string realFullPath = myTrain + "/" + lblTxtUUID.Text;
            long rand_id = 0;

            // 데이터 추가
            ProductVO productVO = new ProductVO();
            ProductBarcodeVO productBarcodeVO = new ProductBarcodeVO();
            Random rand = new Random();

            productVO.project_id = int.Parse(txtProjectId.Text);
            productVO.product_name = txtProductName.Text;
            productVO.description = txtDescription.Text;
            productVO.regidate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            productVO.ip = util.Network.GetMyIP();

            productService.InsertProduct(productVO);
            ProductVO resultVO = productService.SelectProductOne(productVO);

            // 바코드 생성
            if (resultVO != null)
            {
                productBarcodeVO.product_id = resultVO.product_id;

                while (status_rand_id)
                {

                    rand_id = rand.NextInt64(1000000000000, 9999999999999);
                    productBarcodeVO.rand_id = rand_id.ToString();

                    ProductBarcodeVO resultRandId = productService.SelectProductBarcodeFindRandId(productBarcodeVO);


                    if (resultRandId == null)
                    {
                        productBarcodeVO.regidate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        productBarcodeVO.ip = util.Network.GetMyIP();

                        // 박스 등록 처리
                        productService.InsertProductBarcode(productBarcodeVO);

                        status_rand_id = false;

                    }

                }

            }

            // 이미지 생성
            if (resultVO != null)
            {
                ProductImgDictionaryVO imgDictionaryVO = new ProductImgDictionaryVO();
                imgDictionaryVO.product_id = resultVO.product_id;
                imgDictionaryVO.type = "셈플";
                imgDictionaryVO.uuid = lblTxtUUID.Text;
                imgDictionaryVO.train_dir = "train";
                imgDictionaryVO.regidate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                imgDictionaryVO.ip = util.Network.GetMyIP();

                // 파일 목록 검색
                String FolderName = realFullPath;
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(FolderName);
                foreach (System.IO.FileInfo File in di.GetFiles())
                {
                    if (File.Extension.ToLower().CompareTo(".jpg") == 0)
                    {
                        String FileNameOnly = File.Name.Substring(0, File.Name.Length - 4);
                        String FullName = File.Name;

                        imgDictionaryVO.file_name = FullName;
                        //MessageBox.Show(FullFileName + " " + FileNameOnly);

                        productService.InsertProductImgDictionary(imgDictionaryVO);

                    }

                }

            }

            // 박스 생성
            if ( resultVO != null)
            {

                ProductBoxSpecVO productBoxSpecVO = new ProductBoxSpecVO();
                productBoxSpecVO.product_id = resultVO.product_id;
                productBoxSpecVO.box_type_id = 1;
                productBoxSpecVO.width = 0;
                productBoxSpecVO.length = 0;
                productBoxSpecVO.height = 0;
                productBoxSpecVO.box_name = "해당없음";
                productBoxSpecVO.regidate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                productBoxSpecVO.ip = util.Network.GetMyIP();

                productService.InsertProductBoxSpec(productBoxSpecVO);

            }

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
                    
                    if (mat != null) { 
                        mat.Dispose();
                    }

                    if (destMat != null) {
                        destMat.Dispose();
                    }

                    thread.Interrupt();

                }

            }

        }

        private void btnZoomUp_Click(object sender, EventArgs e)
        {
            zoom_up();

        }

        private void zoom_up()
        {

            if (thread != null &&
                thread.IsAlive &&
                videoCapture != null)
            {
                if (videoCapture.IsOpened())
                {
                    // 줌 실행
                    isZoomUp = true;

                }

            }
            else
            {
                MessageBox.Show("카메라를 불러오지 않았습니다.", "확인",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            prevFrm();
        }

        private void prevFrm()
        {
            string sendData = txtProjectId.Text;
            sendData = sendData + "/" + txtProjectName.Text;
            sendData = sendData + "/" + txtProductName.Text;
            sendData = sendData + "," + txtDescription.Text + "/";

            ProductCameraTestFrm frm = new ProductCameraTestFrm(sendData);
            frm.Show();
            this.Hide();
        }
    }

}
