/*
 * Created Date: 2022-07-22 (Fri)
 * Author: Doyun Jung (정도윤) / rabbit.white@daum.net
 * Subject: AICreateModelFrm
 * Filename: AICreateModelFrm.cs
 * Description:
 * 
 * 
 * 
 */
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
    public partial class AICreateModelFrm : Form
    {
        const int CHOOSE_DATA_CLASSFICATION = 1;
        const int CHOOSE_CREATE_MODEL = 2;
        const int CHOOSE_PREDICT = 3;

        const int MAX_PROGRESS = 100;

        Thread thread;
        int choose;
        int multi_num;
        bool active;
        string usrMsg_start;
        string usrMsg_end;
        string usrPath;
        string usrPythonFile;
        string usrExeFile;
        string usrArgu;

        // 델리게이트 생성 (쓰레드에서 프로그래스 접근을 위함)
        delegate void myDelegate(int i, int max);

        public AICreateModelFrm()
        {
            InitializeComponent();
            
            // 프로그래스 기본 설정
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            multi_num = 0;

            // 쓰레드 설정
            thread = null;
            active = false;
        }

        private void AICreateModelFrm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void btnDataClassfication_Click(object sender, EventArgs e)
        {

            SMConfig config = new SMConfig();

            var path = @config.GetMyConfig(SMConfig.ROOT_DIR) + "//source";
            var pythonFileName = "3_cnn_image_multi_classfication_scarp.py";

            //MessageBox.Show(path);
            choose = CHOOSE_DATA_CLASSFICATION;
            multi_num = 0;
            updateProgress(0, MAX_PROGRESS);

            usrPath = path;
            usrPythonFile = pythonFileName;
            usrExeFile = "python.exe";
            usrArgu = "";
            usrMsg_start = "데이터 분류를 생성합니다.";
            usrMsg_end = "성공적으로 생성되었습니다.";


            if (active == false)
            {
                thread = new Thread(new ThreadStart(Run_python));
                thread.Start();
            }
            else
            {
                MessageBox.Show("실행중인 프로세스가 존재합니다.", "확인",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnCreateModel_Click(object sender, EventArgs e)
        {

            SMConfig config = new SMConfig();

            var path = @config.GetMyConfig(SMConfig.ROOT_DIR) + "//source";
            var pythonFileName = "3_cnn_image_multi_classfication_load.py";

            //MessageBox.Show(path);
            choose = CHOOSE_CREATE_MODEL;
            multi_num = 0;
            updateProgress(0, MAX_PROGRESS);

            usrPath = path;
            usrPythonFile = pythonFileName;
            usrExeFile = "python.exe";
            usrArgu = "";
            usrMsg_start = "학습 모델을 생성합니다.";
            usrMsg_end = "성공적으로 생성되었습니다.";

            if (active == false)
            {
                thread = new Thread(new ThreadStart(Run_python));
                thread.Start();
            }
            else
            {
                MessageBox.Show("실행중인 프로세스가 존재합니다.", "확인",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnFileDialog_Click(object sender, EventArgs e)
        {

            txtFilePath.Clear();
            String file_path = null;

            openFileDialog1.InitialDirectory = "C:\\";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file_path = openFileDialog1.FileName;
                //txtFilePath.Text = file_path.Split('\\')[file_path.Split('\\').Length - 1];
                txtFilePath.Text = file_path;
            }

        }


        private void btnPredict_Click(object sender, EventArgs e)
        {
            SMConfig config = new SMConfig();

            var path = @config.GetMyConfig(SMConfig.ROOT_DIR) + "//source";
            var pythonFileName = "3_cnn_image_multi_classfication_predict.py";

            //MessageBox.Show(path);
            usrPath = path;
            usrPythonFile = pythonFileName;
            usrExeFile = "python.exe";
            usrArgu = txtFilePath.Text;
            usrArgu = @usrArgu.Replace("\\", "//");
            MessageBox.Show(usrArgu);
            usrMsg_start = "사진 파일을 예측합니다.";
            usrMsg_end = "성공적으로 예측되었습니다.";

            if (active == false)
            {
                thread = new Thread(new ThreadStart(Run_python_predict));
                thread.Start();
            }
            else
            {
                MessageBox.Show("실행중인 프로세스가 존재합니다.", "확인",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Run_python()
        {
            MessageBox.Show(usrMsg_start, "확인", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            updateProgress(0, 100);
            Run_cmd(usrPath, usrPythonFile, usrExeFile, usrArgu);

            MessageBox.Show(usrMsg_end, "확인",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Run_python_predict()
        {
            MessageBox.Show(usrMsg_start, "확인",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            Run_cmd_predict(usrPath, usrPythonFile, usrExeFile, usrArgu);

            MessageBox.Show(usrMsg_end, "확인",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // progressBar 변경
        private void updateProgress(int _value, int _max)
        {
            try
            {

                if (choose == CHOOSE_DATA_CLASSFICATION)
                {
                    this.progressBar1.Maximum = _max;
                    this.progressBar2.Value = 0;

                    if (progressBar1.Value < _max)
                    {
                        progressBar1.Value = _value;
                    }
                    else
                    {
                        progressBar2.Maximum = _max * multi_num;
                        progressBar2.Value = _value;
                    }

                }
                else if (choose == CHOOSE_CREATE_MODEL)
                {
                    this.progressBar1.Value = 0;
                    this.progressBar2.Maximum = _max;

                    if (progressBar2.Value < _max)
                    {
                        progressBar2.Value = _value;
                    }
                    else
                    {
                        progressBar2.Maximum = _max * multi_num;
                        progressBar2.Value = _value;
                    }

                }

            }catch(Exception e)
            {
                MessageBox.Show(e.Message, "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Run_cmd(string uPath, string uPythonFile, string uExeFile, string uArgu)
        {

            SMConfig config = new SMConfig();
            active = true;
            int _max_progress = MAX_PROGRESS;

            string filename = @config.GetMyConfig(SMConfig.PYTHON_ROOT_DIR) + "//" + uExeFile;

            var psi = new ProcessStartInfo
            {
                FileName = filename, // 파이썬 설치 경로
                Arguments = $"{uPath}//{uPythonFile}",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            var erros = string.Empty;
            var results = string.Empty;
            string tmp = "";

            int t_i = 0;

            using (Process process = Process.Start(psi))
            {
                using (StreamReader reader = process.StandardOutput)
                {

                    while (!process.HasExited)
                    {
                        //Console.WriteLine(reader.ReadLine());
                        //WMessageBox.Show(reader.ReadLine());
                        tmp = reader.ReadLine();

                        //MessageBox.Show(tmp);

                        if (tmp != null)
                        {
                            if (t_i > _max_progress)
                            {
                                _max_progress *= 2;
                            }

                            // 델리게이트호출
                            this.Invoke(new myDelegate(updateProgress), new object[] { t_i, _max_progress });
                            Thread.Sleep(10);

                            t_i++;

                        }

                    }

                    // 델리게이트호출
                    this.Invoke(new myDelegate(updateProgress), new object[] { _max_progress, _max_progress });
                    Thread.Sleep(10);
                    

                    erros = process.StandardError.ReadToEnd();
                    results = process.StandardOutput.ReadToEnd();
                }
            }

            Console.WriteLine(erros);
            Console.WriteLine(results);

            active = false;

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

        private void AICreateModelFrm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStatuslbl.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
