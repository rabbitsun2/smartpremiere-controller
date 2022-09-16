namespace SmartLogistics
{
    partial class RobotArmControllerFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMonitor = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.lblCommand = new System.Windows.Forms.Label();
            this.lblComPort = new System.Windows.Forms.Label();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.lblComPort2 = new System.Windows.Forms.Label();
            this.cmb_comPort = new System.Windows.Forms.ComboBox();
            this.cmb_baudRate = new System.Windows.Forms.ComboBox();
            this.btnConn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMotion_6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMotion_5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMotion_4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMotion_3 = new System.Windows.Forms.Button();
            this.lblRobotArmDemoStart = new System.Windows.Forms.Label();
            this.btnRobotArmStart = new System.Windows.Forms.Button();
            this.lblMotor6 = new System.Windows.Forms.Label();
            this.btnMotion_2 = new System.Windows.Forms.Button();
            this.lblMotor5 = new System.Windows.Forms.Label();
            this.btnMotion_1 = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRotateM6_rotate_45deg_rev = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRotateM6_rotate_45deg_forward = new System.Windows.Forms.Button();
            this.btnRotateM5_rotate_45deg_rev = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRotateM5_rotate_45deg_forward = new System.Windows.Forms.Button();
            this.btnRotateM0_rotate_90deg_rev = new System.Windows.Forms.Button();
            this.btnRotateM0_rotate_45deg_rev = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRotateM0_rotate_90deg_forward = new System.Windows.Forms.Button();
            this.btnRotateM0_rotate_45deg_forward = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(12, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(92, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "로봇 팔 제어";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblMonitor);
            this.panel2.Controls.Add(this.txtData);
            this.panel2.Location = new System.Drawing.Point(366, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 190);
            this.panel2.TabIndex = 8;
            // 
            // lblMonitor
            // 
            this.lblMonitor.AutoSize = true;
            this.lblMonitor.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMonitor.Location = new System.Drawing.Point(13, 20);
            this.lblMonitor.Name = "lblMonitor";
            this.lblMonitor.Size = new System.Drawing.Size(47, 15);
            this.lblMonitor.TabIndex = 1;
            this.lblMonitor.Text = "대화 창";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(13, 49);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtData.Size = new System.Drawing.Size(347, 108);
            this.txtData.TabIndex = 20;
            this.txtData.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.txtCommand);
            this.panel1.Controls.Add(this.lblCommand);
            this.panel1.Controls.Add(this.lblComPort);
            this.panel1.Controls.Add(this.lblBaudRate);
            this.panel1.Controls.Add(this.lblComPort2);
            this.panel1.Controls.Add(this.cmb_comPort);
            this.panel1.Controls.Add(this.cmb_baudRate);
            this.panel1.Controls.Add(this.btnConn);
            this.panel1.Location = new System.Drawing.Point(11, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 135);
            this.panel1.TabIndex = 7;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSend.Location = new System.Drawing.Point(262, 101);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 24);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "전송";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCommand.Location = new System.Drawing.Point(94, 103);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(157, 21);
            this.txtCommand.TabIndex = 4;
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCommand.Location = new System.Drawing.Point(12, 105);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(71, 15);
            this.lblCommand.TabIndex = 8;
            this.lblCommand.Text = "Command";
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblComPort.Location = new System.Drawing.Point(12, 19);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(63, 15);
            this.lblComPort.TabIndex = 7;
            this.lblComPort.Text = "COM포트";
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBaudRate.Location = new System.Drawing.Point(12, 77);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(65, 15);
            this.lblBaudRate.TabIndex = 6;
            this.lblBaudRate.Text = "BaudRate";
            // 
            // lblComPort2
            // 
            this.lblComPort2.AutoSize = true;
            this.lblComPort2.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComPort2.Location = new System.Drawing.Point(12, 50);
            this.lblComPort2.Name = "lblComPort2";
            this.lblComPort2.Size = new System.Drawing.Size(63, 15);
            this.lblComPort2.TabIndex = 5;
            this.lblComPort2.Text = "COM포트";
            // 
            // cmb_comPort
            // 
            this.cmb_comPort.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmb_comPort.FormattingEnabled = true;
            this.cmb_comPort.Location = new System.Drawing.Point(94, 45);
            this.cmb_comPort.Name = "cmb_comPort";
            this.cmb_comPort.Size = new System.Drawing.Size(157, 23);
            this.cmb_comPort.TabIndex = 0;
            this.cmb_comPort.Click += new System.EventHandler(this.cmb_comPort_Click);
            // 
            // cmb_baudRate
            // 
            this.cmb_baudRate.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmb_baudRate.FormattingEnabled = true;
            this.cmb_baudRate.Location = new System.Drawing.Point(94, 74);
            this.cmb_baudRate.Name = "cmb_baudRate";
            this.cmb_baudRate.Size = new System.Drawing.Size(157, 23);
            this.cmb_baudRate.TabIndex = 2;
            // 
            // btnConn
            // 
            this.btnConn.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConn.Location = new System.Drawing.Point(262, 45);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(75, 52);
            this.btnConn.TabIndex = 5;
            this.btnConn.Text = "연결";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnMotion_6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnMotion_5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnMotion_4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnMotion_3);
            this.panel3.Controls.Add(this.lblRobotArmDemoStart);
            this.panel3.Controls.Add(this.btnRobotArmStart);
            this.panel3.Controls.Add(this.lblMotor6);
            this.panel3.Controls.Add(this.btnMotion_2);
            this.panel3.Controls.Add(this.lblMotor5);
            this.panel3.Controls.Add(this.btnMotion_1);
            this.panel3.Location = new System.Drawing.Point(11, 192);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(349, 313);
            this.panel3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(188, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "6번 동작";
            // 
            // btnMotion_6
            // 
            this.btnMotion_6.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMotion_6.Location = new System.Drawing.Point(186, 146);
            this.btnMotion_6.Name = "btnMotion_6";
            this.btnMotion_6.Size = new System.Drawing.Size(146, 32);
            this.btnMotion_6.TabIndex = 13;
            this.btnMotion_6.Text = "시작(Start)";
            this.btnMotion_6.UseVisualStyleBackColor = true;
            this.btnMotion_6.Click += new System.EventHandler(this.btnMotion_6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "5번 동작";
            // 
            // btnMotion_5
            // 
            this.btnMotion_5.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMotion_5.Location = new System.Drawing.Point(12, 146);
            this.btnMotion_5.Name = "btnMotion_5";
            this.btnMotion_5.Size = new System.Drawing.Size(146, 32);
            this.btnMotion_5.TabIndex = 12;
            this.btnMotion_5.Text = "시작(Start)";
            this.btnMotion_5.UseVisualStyleBackColor = true;
            this.btnMotion_5.Click += new System.EventHandler(this.btnMotion_5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(188, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "4번 동작";
            // 
            // btnMotion_4
            // 
            this.btnMotion_4.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMotion_4.Location = new System.Drawing.Point(186, 90);
            this.btnMotion_4.Name = "btnMotion_4";
            this.btnMotion_4.Size = new System.Drawing.Size(146, 32);
            this.btnMotion_4.TabIndex = 11;
            this.btnMotion_4.Text = "시작(Start)";
            this.btnMotion_4.UseVisualStyleBackColor = true;
            this.btnMotion_4.Click += new System.EventHandler(this.btnMotion_4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "3번 동작";
            // 
            // btnMotion_3
            // 
            this.btnMotion_3.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMotion_3.Location = new System.Drawing.Point(12, 90);
            this.btnMotion_3.Name = "btnMotion_3";
            this.btnMotion_3.Size = new System.Drawing.Size(146, 32);
            this.btnMotion_3.TabIndex = 10;
            this.btnMotion_3.Text = "시작(Start)";
            this.btnMotion_3.UseVisualStyleBackColor = true;
            this.btnMotion_3.Click += new System.EventHandler(this.btnMotion_3_Click);
            // 
            // lblRobotArmDemoStart
            // 
            this.lblRobotArmDemoStart.AutoSize = true;
            this.lblRobotArmDemoStart.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRobotArmDemoStart.Location = new System.Drawing.Point(13, 182);
            this.lblRobotArmDemoStart.Name = "lblRobotArmDemoStart";
            this.lblRobotArmDemoStart.Size = new System.Drawing.Size(103, 15);
            this.lblRobotArmDemoStart.TabIndex = 23;
            this.lblRobotArmDemoStart.Text = "로봇 팔 부팅 시작";
            // 
            // btnRobotArmStart
            // 
            this.btnRobotArmStart.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRobotArmStart.Location = new System.Drawing.Point(12, 202);
            this.btnRobotArmStart.Name = "btnRobotArmStart";
            this.btnRobotArmStart.Size = new System.Drawing.Size(146, 32);
            this.btnRobotArmStart.TabIndex = 14;
            this.btnRobotArmStart.Text = "정 방향(Forward)";
            this.btnRobotArmStart.UseVisualStyleBackColor = true;
            this.btnRobotArmStart.Click += new System.EventHandler(this.btnRobotArmStart_Click);
            // 
            // lblMotor6
            // 
            this.lblMotor6.AutoSize = true;
            this.lblMotor6.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMotor6.Location = new System.Drawing.Point(188, 14);
            this.lblMotor6.Name = "lblMotor6";
            this.lblMotor6.Size = new System.Drawing.Size(55, 15);
            this.lblMotor6.TabIndex = 21;
            this.lblMotor6.Text = "2번 동작";
            // 
            // btnMotion_2
            // 
            this.btnMotion_2.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMotion_2.Location = new System.Drawing.Point(186, 34);
            this.btnMotion_2.Name = "btnMotion_2";
            this.btnMotion_2.Size = new System.Drawing.Size(146, 32);
            this.btnMotion_2.TabIndex = 9;
            this.btnMotion_2.Text = "시작(Start)";
            this.btnMotion_2.UseVisualStyleBackColor = true;
            this.btnMotion_2.Click += new System.EventHandler(this.btnMotion_2_Click);
            // 
            // lblMotor5
            // 
            this.lblMotor5.AutoSize = true;
            this.lblMotor5.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMotor5.Location = new System.Drawing.Point(14, 14);
            this.lblMotor5.Name = "lblMotor5";
            this.lblMotor5.Size = new System.Drawing.Size(55, 15);
            this.lblMotor5.TabIndex = 18;
            this.lblMotor5.Text = "1번 동작";
            // 
            // btnMotion_1
            // 
            this.btnMotion_1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMotion_1.Location = new System.Drawing.Point(12, 34);
            this.btnMotion_1.Name = "btnMotion_1";
            this.btnMotion_1.Size = new System.Drawing.Size(146, 32);
            this.btnMotion_1.TabIndex = 8;
            this.btnMotion_1.Text = "시작(Start)";
            this.btnMotion_1.UseVisualStyleBackColor = true;
            this.btnMotion_1.Click += new System.EventHandler(this.btnMotion_1_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrev.Location = new System.Drawing.Point(1082, 18);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(84, 29);
            this.btnPrev.TabIndex = 10;
            this.btnPrev.Text = "이전";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.picBox);
            this.panel5.Location = new System.Drawing.Point(747, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(419, 353);
            this.panel5.TabIndex = 12;
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Location = new System.Drawing.Point(11, 11);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(396, 331);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnRotateM6_rotate_45deg_rev);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.btnRotateM6_rotate_45deg_forward);
            this.panel4.Controls.Add(this.btnRotateM5_rotate_45deg_rev);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.btnRotateM5_rotate_45deg_forward);
            this.panel4.Controls.Add(this.btnRotateM0_rotate_90deg_rev);
            this.panel4.Controls.Add(this.btnRotateM0_rotate_45deg_rev);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.btnRotateM0_rotate_90deg_forward);
            this.panel4.Controls.Add(this.btnRotateM0_rotate_45deg_forward);
            this.panel4.Location = new System.Drawing.Point(366, 249);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(375, 256);
            this.panel4.TabIndex = 13;
            // 
            // btnRotateM6_rotate_45deg_rev
            // 
            this.btnRotateM6_rotate_45deg_rev.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRotateM6_rotate_45deg_rev.Location = new System.Drawing.Point(186, 202);
            this.btnRotateM6_rotate_45deg_rev.Name = "btnRotateM6_rotate_45deg_rev";
            this.btnRotateM6_rotate_45deg_rev.Size = new System.Drawing.Size(146, 32);
            this.btnRotateM6_rotate_45deg_rev.TabIndex = 49;
            this.btnRotateM6_rotate_45deg_rev.Text = "역 방향(Reverse)";
            this.btnRotateM6_rotate_45deg_rev.UseVisualStyleBackColor = true;
            this.btnRotateM6_rotate_45deg_rev.Click += new System.EventHandler(this.btnRotateM6_rotate_45deg_rev_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(13, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 15);
            this.label9.TabIndex = 50;
            this.label9.Text = "6번 모터/45도";
            // 
            // btnRotateM6_rotate_45deg_forward
            // 
            this.btnRotateM6_rotate_45deg_forward.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRotateM6_rotate_45deg_forward.Location = new System.Drawing.Point(12, 202);
            this.btnRotateM6_rotate_45deg_forward.Name = "btnRotateM6_rotate_45deg_forward";
            this.btnRotateM6_rotate_45deg_forward.Size = new System.Drawing.Size(146, 32);
            this.btnRotateM6_rotate_45deg_forward.TabIndex = 48;
            this.btnRotateM6_rotate_45deg_forward.Text = "정 방향(Forward)";
            this.btnRotateM6_rotate_45deg_forward.UseVisualStyleBackColor = true;
            this.btnRotateM6_rotate_45deg_forward.Click += new System.EventHandler(this.btnRotateM6_rotate_45deg_forward_Click);
            // 
            // btnRotateM5_rotate_45deg_rev
            // 
            this.btnRotateM5_rotate_45deg_rev.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRotateM5_rotate_45deg_rev.Location = new System.Drawing.Point(186, 145);
            this.btnRotateM5_rotate_45deg_rev.Name = "btnRotateM5_rotate_45deg_rev";
            this.btnRotateM5_rotate_45deg_rev.Size = new System.Drawing.Size(146, 32);
            this.btnRotateM5_rotate_45deg_rev.TabIndex = 46;
            this.btnRotateM5_rotate_45deg_rev.Text = "역 방향(Reverse)";
            this.btnRotateM5_rotate_45deg_rev.UseVisualStyleBackColor = true;
            this.btnRotateM5_rotate_45deg_rev.Click += new System.EventHandler(this.btnRotateM5_rotate_45deg_rev_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(13, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 15);
            this.label8.TabIndex = 47;
            this.label8.Text = "5번 모터/45도";
            // 
            // btnRotateM5_rotate_45deg_forward
            // 
            this.btnRotateM5_rotate_45deg_forward.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRotateM5_rotate_45deg_forward.Location = new System.Drawing.Point(12, 145);
            this.btnRotateM5_rotate_45deg_forward.Name = "btnRotateM5_rotate_45deg_forward";
            this.btnRotateM5_rotate_45deg_forward.Size = new System.Drawing.Size(146, 32);
            this.btnRotateM5_rotate_45deg_forward.TabIndex = 45;
            this.btnRotateM5_rotate_45deg_forward.Text = "정 방향(Forward)";
            this.btnRotateM5_rotate_45deg_forward.UseVisualStyleBackColor = true;
            this.btnRotateM5_rotate_45deg_forward.Click += new System.EventHandler(this.btnRotateM5_rotate_45deg_forward_Click);
            // 
            // btnRotateM0_rotate_90deg_rev
            // 
            this.btnRotateM0_rotate_90deg_rev.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRotateM0_rotate_90deg_rev.Location = new System.Drawing.Point(186, 89);
            this.btnRotateM0_rotate_90deg_rev.Name = "btnRotateM0_rotate_90deg_rev";
            this.btnRotateM0_rotate_90deg_rev.Size = new System.Drawing.Size(146, 32);
            this.btnRotateM0_rotate_90deg_rev.TabIndex = 42;
            this.btnRotateM0_rotate_90deg_rev.Text = "역 방향(Reverse)";
            this.btnRotateM0_rotate_90deg_rev.UseVisualStyleBackColor = true;
            this.btnRotateM0_rotate_90deg_rev.Click += new System.EventHandler(this.btnRotateM0_rotate_90deg_rev_Click);
            // 
            // btnRotateM0_rotate_45deg_rev
            // 
            this.btnRotateM0_rotate_45deg_rev.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRotateM0_rotate_45deg_rev.Location = new System.Drawing.Point(186, 33);
            this.btnRotateM0_rotate_45deg_rev.Name = "btnRotateM0_rotate_45deg_rev";
            this.btnRotateM0_rotate_45deg_rev.Size = new System.Drawing.Size(146, 32);
            this.btnRotateM0_rotate_45deg_rev.TabIndex = 40;
            this.btnRotateM0_rotate_45deg_rev.Text = "역 방향(Reverse)";
            this.btnRotateM0_rotate_45deg_rev.UseVisualStyleBackColor = true;
            this.btnRotateM0_rotate_45deg_rev.Click += new System.EventHandler(this.btnRotateM0_rotate_45deg_rev_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(13, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 44;
            this.label6.Text = "1번 모터/90도";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(13, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 15);
            this.label7.TabIndex = 43;
            this.label7.Text = "1번 모터/45도";
            // 
            // btnRotateM0_rotate_90deg_forward
            // 
            this.btnRotateM0_rotate_90deg_forward.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRotateM0_rotate_90deg_forward.Location = new System.Drawing.Point(12, 89);
            this.btnRotateM0_rotate_90deg_forward.Name = "btnRotateM0_rotate_90deg_forward";
            this.btnRotateM0_rotate_90deg_forward.Size = new System.Drawing.Size(146, 32);
            this.btnRotateM0_rotate_90deg_forward.TabIndex = 41;
            this.btnRotateM0_rotate_90deg_forward.Text = "정 방향(Forward)";
            this.btnRotateM0_rotate_90deg_forward.UseVisualStyleBackColor = true;
            this.btnRotateM0_rotate_90deg_forward.Click += new System.EventHandler(this.btnRotateM0_rotate_90deg_forward_Click);
            // 
            // btnRotateM0_rotate_45deg_forward
            // 
            this.btnRotateM0_rotate_45deg_forward.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRotateM0_rotate_45deg_forward.Location = new System.Drawing.Point(12, 33);
            this.btnRotateM0_rotate_45deg_forward.Name = "btnRotateM0_rotate_45deg_forward";
            this.btnRotateM0_rotate_45deg_forward.Size = new System.Drawing.Size(146, 32);
            this.btnRotateM0_rotate_45deg_forward.TabIndex = 39;
            this.btnRotateM0_rotate_45deg_forward.Text = "정 방향(Forward)";
            this.btnRotateM0_rotate_45deg_forward.UseVisualStyleBackColor = true;
            this.btnRotateM0_rotate_45deg_forward.Click += new System.EventHandler(this.btnRotateM0_rotate_45deg_forward_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RobotArmControllerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 519);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RobotArmControllerFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "로봇 팔 제어";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RobotArmControllerFrm_FormClosing);
            this.Load += new System.EventHandler(this.RobotArmControllerFrm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Panel panel2;
        private Label lblMonitor;
        private TextBox txtData;
        private Panel panel1;
        private Label lblComPort;
        private Label lblBaudRate;
        private Label lblComPort2;
        private ComboBox cmb_comPort;
        private ComboBox cmb_baudRate;
        private Button btnConn;
        private Panel panel3;
        private Button btnPrev;
        private Label lblCommand;
        private TextBox txtCommand;
        private Button btnSend;
        private Label lblMotor6;
        private Button btnMotion_2;
        private Label lblMotor5;
        private Button btnMotion_1;
        private Panel panel5;
        private PictureBox picBox;
        private Label lblRobotArmDemoStart;
        private Button btnRobotArmStart;
        private Label label2;
        private Button btnMotion_3;
        private Label label3;
        private Button btnMotion_4;
        private Label label4;
        private Button btnMotion_6;
        private Label label5;
        private Button btnMotion_5;
        private Panel panel4;
        private Button btnRotateM0_rotate_90deg_rev;
        private Button btnRotateM0_rotate_45deg_rev;
        private Label label6;
        private Label label7;
        private Button btnRotateM0_rotate_90deg_forward;
        private Button btnRotateM0_rotate_45deg_forward;
        private Button btnRotateM5_rotate_45deg_rev;
        private Label label8;
        private Button btnRotateM5_rotate_45deg_forward;
        private Button btnRotateM6_rotate_45deg_rev;
        private Label label9;
        private Button btnRotateM6_rotate_45deg_forward;
        private System.Windows.Forms.Timer timer1;
    }
}