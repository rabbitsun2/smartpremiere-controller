/*
 * Created Date: 2022-06-28 (Tue)
 * Author: Doyun Jung (정도윤) / rabbit.white@daum.net
 * Subject: ProductCameraTest
 * Filename: ProductCameraTest.cs
 * Description:
 * - 1. 
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
using OpenCvSharp.Extensions;

namespace SmartLogistics
{
    public partial class ProductCameraTestFrm : Form
    {
        bool isCameraOn;
        bool isZoomUp;

        Thread thread;
        Mat mat;
        Mat destMat;
        VideoCapture videoCapture;


        public ProductCameraTestFrm(string recvData)
        {
            InitializeComponent();

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            thread = null;
            mat = null;
            destMat = null;
            videoCapture = null;

            isCameraOn = false;
            isZoomUp = false;
            

            // 데이터 값 가져오기
            string tmp = recvData.Substring(0, recvData.IndexOf("/"));
            lblTxtProjectId.Text = tmp;
            recvData = recvData.Replace(tmp + "/", "");
            tmp = recvData.Substring(0, recvData.IndexOf("/"));
            lblTxtProjectName.Text = tmp;
            recvData = recvData.Replace(tmp + "/", "");
            tmp = recvData.Substring(0, recvData.IndexOf(","));
            txtProductName.Text = tmp;
            recvData = recvData.Replace(tmp + ",", "");
            tmp = recvData.Substring(0, recvData.IndexOf("/"));
            lblTxtDescription.Text = tmp;

            // 키 단축키
            KeyPreview = true;

        }

        private void ProductCameraTest_Load(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(CameraCallback));

            thread.Start();
            isCameraOn = true;
            isZoomUp = false;
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
                    if (mat.Empty() )
                    {
                        break;
                    }

                    destMat = mat;

                    // Gaussian 필터 적용
                    Cv2.GaussianBlur(mat, destMat, new OpenCvSharp.Size(), (double)1);

                    // 언샤프 마스크 필터 적용
                    float alpha = 1f;
                    destMat = (1 + alpha) * mat - alpha * destMat;

                    // ImShow 실행하기
                    if ( isZoomUp == true )
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
                    

                }
                catch (Exception ex)
                {

                }

                Cv2.DestroyAllWindows();

            }

        }

        private void ProductCameraTest_FormClosing(object sender, FormClosingEventArgs e)
        {

            // 카메라 종료
            cameraClosed();

            // Process Kill
            System.Diagnostics.Process[] mProcess = System.Diagnostics.Process.GetProcessesByName(Application.ProductName);
            foreach (System.Diagnostics.Process p in mProcess)
                p.Kill();

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            prevFrm();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            nextCaptureFrm();
        }

        private void prevFrm()
        {

            isCameraOn = false;
            isZoomUp = false;


            // 폼 이동
            ProductMainFrm frm = new ProductMainFrm();
            frm.Show();
            this.Hide();

            cameraClosed();

        }

        private void nextCaptureFrm()
        {
            isCameraOn = false;
            isZoomUp = false;

            if (thread != null &&
                thread.IsAlive &&
                videoCapture != null)
            {
                if (videoCapture.IsOpened())
                {
                    cameraClosed();

                    // 데이터 값 전송
                    string sendData = lblTxtProjectId.Text + "/" + lblTxtProjectName.Text + "/";
                    sendData += txtProductName.Text + "," + lblTxtDescription.Text + "/";

                    // 폼 이동
                    ProductCameraCaptureFrm frm = new ProductCameraCaptureFrm(sendData);
                    frm.Show();
                    this.Hide();

                }

            }
            else
            {
                MessageBox.Show("카메라를 불러오지 않았습니다.", "확인",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ProductCameraTest_KeyDown(object sender, KeyEventArgs e)
        {

            if ( e.Control && e.KeyCode == Keys.P)
            {
                prevFrm();
            }

            else if ( e.Control && e.KeyCode == Keys.N)
            {
                nextCaptureFrm();
            }

            else if ( e.Control && e.KeyCode == Keys.Z)
            {
                zoom_up();
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

    }
}
