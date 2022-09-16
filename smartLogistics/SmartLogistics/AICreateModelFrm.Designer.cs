namespace SmartLogistics
{
    partial class AICreateModelFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.lblCreateModel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblProgressDataClassfication = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPredict = new System.Windows.Forms.Button();
            this.btnFileDialog = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnCreateModel = new System.Windows.Forms.Button();
            this.btnDataClassfication = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnPrev = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStatuslbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.progressBar2);
            this.panel1.Controls.Add(this.lblCreateModel);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.lblProgressDataClassfication);
            this.panel1.Location = new System.Drawing.Point(26, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 280);
            this.panel1.TabIndex = 0;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(-2, 149);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(314, 23);
            this.progressBar2.TabIndex = 4;
            // 
            // lblCreateModel
            // 
            this.lblCreateModel.AutoSize = true;
            this.lblCreateModel.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCreateModel.Location = new System.Drawing.Point(3, 123);
            this.lblCreateModel.Name = "lblCreateModel";
            this.lblCreateModel.Size = new System.Drawing.Size(108, 15);
            this.lblCreateModel.TabIndex = 3;
            this.lblCreateModel.Text = "모델 생성 - 진도율";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-2, 81);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(314, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // lblProgressDataClassfication
            // 
            this.lblProgressDataClassfication.AutoSize = true;
            this.lblProgressDataClassfication.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProgressDataClassfication.Location = new System.Drawing.Point(3, 55);
            this.lblProgressDataClassfication.Name = "lblProgressDataClassfication";
            this.lblProgressDataClassfication.Size = new System.Drawing.Size(120, 15);
            this.lblProgressDataClassfication.TabIndex = 1;
            this.lblProgressDataClassfication.Text = "데이터 분류 - 진도율";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.btnCreateModel);
            this.panel3.Controls.Add(this.btnDataClassfication);
            this.panel3.Location = new System.Drawing.Point(380, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 280);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnPredict);
            this.panel2.Controls.Add(this.btnFileDialog);
            this.panel2.Controls.Add(this.txtFilePath);
            this.panel2.Location = new System.Drawing.Point(23, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 134);
            this.panel2.TabIndex = 2;
            // 
            // btnPredict
            // 
            this.btnPredict.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPredict.Location = new System.Drawing.Point(16, 91);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(308, 26);
            this.btnPredict.TabIndex = 2;
            this.btnPredict.Text = "예측";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // btnFileDialog
            // 
            this.btnFileDialog.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFileDialog.Location = new System.Drawing.Point(16, 55);
            this.btnFileDialog.Name = "btnFileDialog";
            this.btnFileDialog.Size = new System.Drawing.Size(308, 30);
            this.btnFileDialog.TabIndex = 1;
            this.btnFileDialog.Text = "파일 열기";
            this.btnFileDialog.UseVisualStyleBackColor = true;
            this.btnFileDialog.Click += new System.EventHandler(this.btnFileDialog_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFilePath.Location = new System.Drawing.Point(16, 21);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(308, 22);
            this.txtFilePath.TabIndex = 0;
            // 
            // btnCreateModel
            // 
            this.btnCreateModel.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateModel.Location = new System.Drawing.Point(210, 51);
            this.btnCreateModel.Name = "btnCreateModel";
            this.btnCreateModel.Size = new System.Drawing.Size(151, 51);
            this.btnCreateModel.TabIndex = 1;
            this.btnCreateModel.Text = "모델 생성";
            this.btnCreateModel.UseVisualStyleBackColor = true;
            this.btnCreateModel.Click += new System.EventHandler(this.btnCreateModel_Click);
            // 
            // btnDataClassfication
            // 
            this.btnDataClassfication.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDataClassfication.Location = new System.Drawing.Point(23, 51);
            this.btnDataClassfication.Name = "btnDataClassfication";
            this.btnDataClassfication.Size = new System.Drawing.Size(151, 51);
            this.btnDataClassfication.TabIndex = 0;
            this.btnDataClassfication.Text = "데이터 분류";
            this.btnDataClassfication.UseVisualStyleBackColor = true;
            this.btnDataClassfication.Click += new System.EventHandler(this.btnDataClassfication_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrev.Location = new System.Drawing.Point(645, 22);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(119, 29);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "이전(P)";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(26, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(87, 21);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "모델 학습";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStatuslbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 386);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStatuslbl
            // 
            this.toolStatuslbl.Name = "toolStatuslbl";
            this.toolStatuslbl.Size = new System.Drawing.Size(121, 17);
            this.toolStatuslbl.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AICreateModelFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AICreateModelFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "물류/생산::: 모델 학습";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AICreateModelFrm_FormClosing);
            this.Load += new System.EventHandler(this.AICreateModelFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label lblProgressDataClassfication;
        private Panel panel3;
        private Button btnDataClassfication;
        private ProgressBar progressBar1;
        private Button btnCreateModel;
        private OpenFileDialog openFileDialog1;
        private Panel panel2;
        private TextBox txtFilePath;
        private Button btnFileDialog;
        private Button btnPredict;
        private ProgressBar progressBar2;
        private Label lblCreateModel;
        private Button btnPrev;
        private Label lblTitle;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStatuslbl;
        private System.Windows.Forms.Timer timer1;
    }
}