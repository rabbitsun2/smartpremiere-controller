/*
 * Created Date: 2022-08-21 (Sun)
 * Author: Doyun Jung (정도윤) / rabbit.white@daum.net
 * Subject: FactorAutomationInputFrm
 * Filename: FactorAutomationInputFrm.cs
 * Description:
 * 
 * 
 * 
 */
using OpenCvSharp;
using SmartLogistics.setting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLogistics
{
    public partial class FactoryAutomationInputFrm : Form
    {

        // 델리게이트 생성 (쓰레드에서 프로그래스 접근을 위함)
        delegate void myDelegate(int i, int max);

        const int MAX_PROGRESS = 100;

        int choose;
        int multi_num;
        bool active;
        string usrMsg_start;
        string usrMsg_end;
        string usrPath;
        string usrPythonFile;
        string usrExeFile;
        string usrArgu;

        bool isCameraOn;
        bool isZoomUp;

        Thread thread;
        Thread ai_machine;
        Mat mat;
        Mat grayMat;
        Mat binaryMat;
        Mat destMat;
        VideoCapture videoCapture;

        public FactoryAutomationInputFrm()
        {
            InitializeComponent();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            FaMainFrm frm = new FaMainFrm();
            frm.Show();
            this.Hide();
        }

        private void FactoryAutomationInputFrm_Load(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(CameraCallback));

            thread.Start();
            isCameraOn = true;


            // UUID 생성 (예비)
            Guid myUUId = Guid.NewGuid();
            string convertedUUID = myUUId.ToString();
            lblTxtUUID.Text = convertedUUID;

        }

        private Mat convertLabel(Mat img, OpenCvSharp.Point[] pts, String label)
        {
            Rect rc = OpenCvSharp.Cv2.BoundingRect(pts);
            Cv2.Rectangle(img, rc, new Scalar(0, 0, 255), 1);
            Cv2.PutText(img, label, rc.TopLeft, HersheyFonts.HersheyPlain, 1, new Scalar(0, 0, 255));

            return img;

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

                    // 그레이스케일 형태로 변환
                    grayMat = mat;
                    grayMat = grayMat.CvtColor(ColorConversionCodes.BGR2GRAY);

                    // Binary 형태로 변환
                    binaryMat = grayMat;
                    binaryMat = binaryMat.Threshold(200, 255, ThresholdTypes.BinaryInv | ThresholdTypes.Otsu);

                    // 윤곽선 찾기
                    OpenCvSharp.Point[][] contours;
                    HierarchyIndex[] hierarchy;

                    Cv2.FindContours(binaryMat, out contours, out hierarchy, 
                        RetrievalModes.External, 
                        ContourApproximationModes.ApproxNone);

                    List<OpenCvSharp.Point[]> new_contours = new List<OpenCvSharp.Point[]>();
                    foreach (OpenCvSharp.Point[] p in contours)
                    {
                        if (Cv2.ContourArea(p) < 580)
                        {
                            continue;
                        }

                        new_contours.Add(Cv2.ApproxPolyDP(p, Cv2.ArcLength(p, true) * 0.02, true));

                        int vtc = new_contours.Count();

                        if (vtc == 3){
                            //destMat = convertLabel(destMat, p, "TRI");
                        }
                        else if (vtc == 4){
                            destMat = convertLabel(destMat, p, "RECT");
                            cheesePhoto();
                        }
                        else if (vtc > 4)
                        {
                            double len = Cv2.ArcLength(p, true);
                            double area = Cv2.ContourArea(p);
                            double ratio = (4 * 3.1415 * area) / (len * len);

                            if(ratio > 0.8)
                            {
                                //destMat = convertLabel(destMat, p, "CIR");
                            }

                        }
                        
                    }


                    System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(destMat.ToBytes());

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

        private void FactoryAutomationInputFrm_FormClosing(object sender, FormClosingEventArgs e)
        {

            isCameraOn = false;
            cameraClosed();

            // Process Kill
            System.Diagnostics.Process[] mProcess = System.Diagnostics.Process.GetProcessesByName(Application.ProductName);
            foreach (System.Diagnostics.Process p in mProcess)
                p.Kill();

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

        private void cheesePhoto()
        {

            if (thread != null &&
                thread.IsAlive &&
                videoCapture != null)
            {
                if (videoCapture.IsOpened())
                {

                    string myPath = setting.SMConfig.GetSmartLogisticsDir();
                    string myTrain = myPath + "/temp";
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

                    string save = DateTime.Now.ToString("yyyyMMdd");
                    save += "-fa";

                    // 사진 저장
                    try
                    {
                        Cv2.ImWrite(realFullPath + "/" + save + ".jpg", mat);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "확인", MessageBoxButtons.OK,
                                                            MessageBoxIcon.Information);
                    }

                    SMConfig config = new SMConfig();

                    var path = @config.GetMyConfig(SMConfig.ROOT_DIR) + "//source";
                    var pythonFileName = "3_cnn_image_multi_classfication_predict.py";

                    //MessageBox.Show(path);
                    usrPath = path;
                    usrPythonFile = pythonFileName;
                    usrExeFile = "python.exe";
                    usrArgu = realFullPath + "/" + save + ".jpg";
                    usrArgu = @usrArgu.Replace("\\", "//");
                    //MessageBox.Show(usrArgu);
                    //usrMsg_start = "사진 파일을 예측합니다.";
                    //usrMsg_end = "성공적으로 예측되었습니다.";


                    if (active == false)
                    {
                        ai_machine = new Thread(new ThreadStart(Run_python_predict));
                        ai_machine.Start();
                    }
                    else
                    {
                        /*MessageBox.Show("실행중인 프로세스가 존재합니다.", "확인",
                                         MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                    }

                }

            }
            else
            {
                MessageBox.Show("카메라가 초기화되지 않았습니다.", "확인",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }


        private void Run_python_predict()
        {
            /*
            MessageBox.Show(usrMsg_start, "확인",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);*/

            Run_cmd_predict(usrPath, usrPythonFile, usrExeFile, usrArgu);

            /*
            MessageBox.Show(usrMsg_end, "확인",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);*/
        }


        public string Run_cmd_predict(string uPath, string uPythonFile, string uExeFile, string uArgu)
        {

            SMConfig config = new SMConfig();
            active = true;
            string result;

            string filename = @config.GetMyConfig(SMConfig.PYTHON_ROOT_DIR) + "//" + uExeFile;

            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = filename;              // @"C:\ProgramData\Miniconda3\python.exe";
            start.Arguments = string.Format("\"{0}\" \"{1}\"", uPath + "//" + uPythonFile, uArgu);
            start.UseShellExecute = false;          // Do not use OS shell
            start.CreateNoWindow = true;            // We don't need new window
            start.RedirectStandardOutput = true;    // Any output, generated by application will be redirected back
            start.RedirectStandardError = true;     // Any error in standard output will be redirected back (for example exceptions)


            using (Process process = Process.Start(start))
            {

                using (StreamReader reader = process.StandardOutput)
                {

                    string stderr = process.StandardError.ReadToEnd(); // Here are the exceptions from our Python script
                    result = reader.ReadToEnd(); // Here is the result of StdOut(for example: print "test")

                    MessageBox.Show(result);

                    active = false;
                    return result;

                }

            }


        }


    }
}
