/*
 * Created Date: 2022-08-10 (Wed)
 * Author: Doyun Jung (정도윤) / rabbit.white@daum.net
 * Subject: RobotArmControllerFrm
 * Filename: RobotArmControllerFrm.cs
 * Description:
 * 1. 로봇 제어 도구 기초 작성, 정도윤, 2022-08-09 (Tue)
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLogistics
{
    public partial class RobotArmControllerFrm : Form
    {
        private const int CHOOSE_TIMER_LOCKED = 1;
        private const int CHOOSE_TIMER_UNLOCKED = 0;

        private int timerLocked;
        private SerialPort serialPort;
        // 델리게이트 생성 (쓰레드에서 프로그래스 접근을 위함)
        delegate void myDelegate(string message);

        public RobotArmControllerFrm()
        {
            InitializeComponent();
            
            serialPort = new SerialPort();          // 시리얼 포트 생성

            loadBaudRate();                         // Baud Rate값 불러오기

            //MessageBox.Show(Application.StartupPath + @"img\robot_arm.png");
            picBox.Load(Application.StartupPath + @"img\robot_arm.png");
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;

            initProcessTimer();                     // 프로세스 타이머 초기화 하기

        }


        private void loadBaudRate()
        {

            // BaudRate 초기화
            cmb_baudRate.Items.Clear();

            // Range of Baud Rate
            cmb_baudRate.Items.Add(300);
            cmb_baudRate.Items.Add(1200);
            cmb_baudRate.Items.Add(2400);
            cmb_baudRate.Items.Add(4800);
            cmb_baudRate.Items.Add(9600);
            cmb_baudRate.Items.Add(19200);
            cmb_baudRate.Items.Add(38400);
            cmb_baudRate.Items.Add(57600);
            cmb_baudRate.Items.Add(115200);
            cmb_baudRate.Items.Add(230400);
            cmb_baudRate.Items.Add(250000);
            cmb_baudRate.Items.Add(500000);
            cmb_baudRate.Items.Add(1000000);
            cmb_baudRate.Items.Add(2000000);

            // 기본 보오드 값(Default Baud Rate)
            cmb_baudRate.Text = "9600";

        }

        private void initProcessTimer()
        {
            // 로봇
            timer1.Enabled = false;
            timer1.Interval = 3000;

            // 타이머 락 해제 상태
            timerLocked = CHOOSE_TIMER_UNLOCKED;

        }

        private void RobotArmControllerFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Process Kill
            System.Diagnostics.Process[] mProcess = System.Diagnostics.Process.GetProcessesByName(Application.ProductName);
            foreach (System.Diagnostics.Process p in mProcess)
                p.Kill();

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            FaMainFrm frm = new FaMainFrm();
            frm.Show();
            this.Hide();
        }

        private void RobotArmControllerFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnConn_Click(object sender, EventArgs e)
        {

            if (cmb_comPort.Text == "")
            {
                MessageBox.Show("연결 후 사용하세요.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                }
                else
                {
                    serialPort.PortName = cmb_comPort.SelectedItem.ToString();
                    serialPort.BaudRate = int.Parse(cmb_baudRate.Text.ToString());
                    serialPort.DataBits = 8;
                    serialPort.StopBits = StopBits.One;
                    serialPort.Parity = Parity.None;

                    serialPort.ReadTimeout = 1000;
                    serialPort.WriteTimeout = 1000;
                    serialPort.ReadBufferSize = 4096;
                    serialPort.ReceivedBytesThreshold = 1;

                    serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    serialPort.Open();

                    serialPort.DtrEnable = true;
                    serialPort.RtsEnable = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("연결 에러", "알림", MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information);
            }

            btnConn.Text = serialPort.IsOpen ? "연결해제" : "연결";
            cmb_comPort.Enabled = !serialPort.IsOpen;

        }

        private void DataReceivedHandler(object sender,
                        SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;

            //MessageBox.Show("receiving!");
            string data = sp.ReadExisting();
            //Console.WriteLine("received: " + data);
            //MessageBox.Show(data);


            // 델리게이트호출
            this.Invoke(new myDelegate(updateMessage), new object[] { data });
            Thread.Sleep(10);

        }

        // progressBar 변경
        private void updateMessage(String message)
        {
            txtData.Text = txtData.Text + message;
        }

        private void cmb_comPort_Click(object sender, EventArgs e)
        {

            cmb_comPort.Items.Clear();

            foreach (var item in SerialPort.GetPortNames())
            {
                cmb_comPort.Items.Add(item);
            }

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
                return;

            serialPort.Write(txtCommand.Text);

        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {
            this.txtData.SelectionStart = txtData.Text.Length;
            this.txtData.ScrollToCaret();
        }

        private void DoAction_RobotArm(String sendData)
        {
            
            // 연결 여부
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("연결 후 사용하세요.", "확인",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            // 프로세스 락 상태
            if (timerLocked == CHOOSE_TIMER_LOCKED)
            {
                MessageBox.Show("프로세스를 이미 사용중입니다.", "확인",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }
            else
            {
                timerLocked = CHOOSE_TIMER_LOCKED;
                timer1.Enabled = true;
                timer1.Start();
            }

            // 로봇 팔 제어 경고문
            if (MessageBox.Show("로봇 팔을 제어하는 데 있어서 위험이 따를 수 있습니다.\n" +
                "계속하시겠습니까?", "확인",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                serialPort.Write( sendData );
            }
            else
            {
                MessageBox.Show("신중하게 선택해주세요.", "확인",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }

        private void btnRobotArmStart_Click(object sender, EventArgs e)
        {
            DoAction_RobotArm("0");
        }


        private void btnMotion_1_Click(object sender, EventArgs e)
        {
            DoAction_RobotArm("1");
        }

        private void btnMotion_2_Click(object sender, EventArgs e)
        {
            DoAction_RobotArm("2");

        }

        private void btnMotion_3_Click(object sender, EventArgs e)
        {
            DoAction_RobotArm("3");

        }

        private void btnMotion_4_Click(object sender, EventArgs e)
        {
            DoAction_RobotArm("4");

        }

        private void btnMotion_5_Click(object sender, EventArgs e)
        {
            DoAction_RobotArm("5");

        }

        private void btnMotion_6_Click(object sender, EventArgs e)
        {
            DoAction_RobotArm("6");

        }

        private void btnRotateM0_rotate_45deg_forward_Click(object sender, EventArgs e)
        {
            DoAction_RobotArm("7");

        }

        private void btnRotateM0_rotate_45deg_rev_Click(object sender, EventArgs e)
        {
            DoAction_RobotArm("8");

        }

        private void btnRotateM0_rotate_90deg_forward_Click(object sender, EventArgs e)
        {
            DoAction_RobotArm("9");

        }

        private void btnRotateM0_rotate_90deg_rev_Click(object sender, EventArgs e)
        {
            DoAction_RobotArm("10");

        }

        private void btnRotateM5_rotate_45deg_forward_Click(object sender, EventArgs e)
        {
            DoAction_RobotArm("11");

        }

        private void btnRotateM5_rotate_45deg_rev_Click(object sender, EventArgs e)
        {
            DoAction_RobotArm("12");

        }

        private void btnRotateM6_rotate_45deg_forward_Click(object sender, EventArgs e)
        {
            DoAction_RobotArm("13");

        }

        private void btnRotateM6_rotate_45deg_rev_Click(object sender, EventArgs e)
        {
            DoAction_RobotArm("14");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerLocked = CHOOSE_TIMER_UNLOCKED;

            timer1.Stop();
            timer1.Enabled = false;
        }

    }

}