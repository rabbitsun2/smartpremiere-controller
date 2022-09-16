namespace SmartLogistics
{
    partial class MachineMgtFrm
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
            this.cmb_comPort = new System.Windows.Forms.ComboBox();
            this.btnConn = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.cmb_baudRate = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblComPort = new System.Windows.Forms.Label();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.lblComPort2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMonitor = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.lblCommand = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_comPort
            // 
            this.cmb_comPort.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmb_comPort.FormattingEnabled = true;
            this.cmb_comPort.Location = new System.Drawing.Point(94, 53);
            this.cmb_comPort.Name = "cmb_comPort";
            this.cmb_comPort.Size = new System.Drawing.Size(157, 23);
            this.cmb_comPort.TabIndex = 0;
            this.cmb_comPort.Click += new System.EventHandler(this.cmb_comPort_Click);
            // 
            // btnConn
            // 
            this.btnConn.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConn.Location = new System.Drawing.Point(262, 53);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(75, 52);
            this.btnConn.TabIndex = 1;
            this.btnConn.Text = "연결";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOpen.Location = new System.Drawing.Point(12, 10);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(146, 32);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "시작";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStop.Location = new System.Drawing.Point(191, 10);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(146, 32);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "종료";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // cmb_baudRate
            // 
            this.cmb_baudRate.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmb_baudRate.FormattingEnabled = true;
            this.cmb_baudRate.Location = new System.Drawing.Point(94, 82);
            this.cmb_baudRate.Name = "cmb_baudRate";
            this.cmb_baudRate.Size = new System.Drawing.Size(157, 23);
            this.cmb_baudRate.TabIndex = 4;
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
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 181);
            this.panel1.TabIndex = 5;
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
            this.lblBaudRate.Location = new System.Drawing.Point(12, 85);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(65, 15);
            this.lblBaudRate.TabIndex = 6;
            this.lblBaudRate.Text = "BaudRate";
            // 
            // lblComPort2
            // 
            this.lblComPort2.AutoSize = true;
            this.lblComPort2.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComPort2.Location = new System.Drawing.Point(12, 58);
            this.lblComPort2.Name = "lblComPort2";
            this.lblComPort2.Size = new System.Drawing.Size(63, 15);
            this.lblComPort2.TabIndex = 5;
            this.lblComPort2.Text = "COM포트";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblMonitor);
            this.panel2.Controls.Add(this.txtData);
            this.panel2.Location = new System.Drawing.Point(372, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 181);
            this.panel2.TabIndex = 6;
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
            this.txtData.TabIndex = 0;
            this.txtData.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "장비 관리 도구";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnOpen);
            this.panel3.Controls.Add(this.btnStop);
            this.panel3.Location = new System.Drawing.Point(12, 266);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(349, 53);
            this.panel3.TabIndex = 8;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSend.Location = new System.Drawing.Point(262, 110);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 24);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "전송";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCommand.Location = new System.Drawing.Point(94, 112);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(157, 21);
            this.txtCommand.TabIndex = 12;
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCommand.Location = new System.Drawing.Point(12, 114);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(71, 15);
            this.lblCommand.TabIndex = 11;
            this.lblCommand.Text = "Command";
            // 
            // MachineMgtFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 331);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MachineMgtFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "장비 관리 도구";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MachineMgtFrm_FormClosing);
            this.Load += new System.EventHandler(this.MachineMgtFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmb_comPort;
        private Button btnConn;
        private Button btnOpen;
        private Button btnStop;
        private ComboBox cmb_baudRate;
        private Panel panel1;
        private Label lblComPort2;
        private Label lblBaudRate;
        private Panel panel2;
        private TextBox txtData;
        private Label lblMonitor;
        private Label lblComPort;
        private Label label1;
        private Panel panel3;
        private Button btnSend;
        private TextBox txtCommand;
        private Label lblCommand;
    }
}