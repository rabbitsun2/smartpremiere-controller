/*
 * Created Date: 2022-08-09 (Tue)
 * Author: Doyun Jung (정도윤) / rabbit.white@daum.net
 * Subject: MachineMgtFrm
 * Filename: MachineMgtFrm.cs
 * Description:
 * 1. 시리얼 장치 관리 구현, 정도윤, 2022-08-09 (Tue)
 * 
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
using System.IO.Ports;
using SmartLogistics.util;

namespace SmartLogistics
{
    public partial class MachineMgtFrm : Form
    {

        private SerialPort serialPort;

        // 델리게이트 생성 (쓰레드에서 프로그래스 접근을 위함)
        delegate void myDelegate(string message);

        public MachineMgtFrm()
        {
            InitializeComponent();
        }

        private void MachineMgtFrm_Load(object sender, EventArgs e)
        {
            serialPort = new SerialPort();
            loadBaudRate();
        }

        private void loadBaudRate()
        {

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

        private void MachineMgtFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Process Kill
            System.Diagnostics.Process[] mProcess = System.Diagnostics.Process.GetProcessesByName(Application.ProductName);
            foreach (System.Diagnostics.Process p in mProcess)
                p.Kill();
        }


        private void btnConn_Click(object sender, EventArgs e)
        {
            if (cmb_comPort.Text == "")
                return;

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
            catch(Exception ex)
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

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
                return;

            serialPort.Write("1");

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
                return;

            serialPort.Write("0");
        }

        private void cmb_comPort_Click(object sender, EventArgs e)
        {

            cmb_comPort.Items.Clear();

            foreach (var item in SerialPort.GetPortNames())
            {
                cmb_comPort.Items.Add(item);
            }
        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {
            this.txtData.SelectionStart = txtData.Text.Length;
            this.txtData.ScrollToCaret();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("연결 후 사용하세요.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            serialPort.Write(txtCommand.Text);

        }

    }
}
