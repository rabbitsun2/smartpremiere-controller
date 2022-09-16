namespace SmartLogistics
{
    partial class ProductCameraTestFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCameraTestFrm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMemo_1 = new System.Windows.Forms.Label();
            this.lblMemo_2 = new System.Windows.Forms.Label();
            this.lblMemo_3 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.lblMemo_4 = new System.Windows.Forms.Label();
            this.panelFuncBox = new System.Windows.Forms.Panel();
            this.btnZoomUp = new System.Windows.Forms.Button();
            this.lblTxtProjectId = new System.Windows.Forms.Label();
            this.lblTxtProjectName = new System.Windows.Forms.Label();
            this.lblTxtDescription = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelFuncBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(335, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(136, 24);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "카메라 테스트";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductName.Location = new System.Drawing.Point(85, 9);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(258, 22);
            this.txtProductName.TabIndex = 1;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProductName.Location = new System.Drawing.Point(20, 12);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(43, 15);
            this.lblProductName.TabIndex = 7;
            this.lblProductName.Text = "품목명";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 286);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblMemo_1
            // 
            this.lblMemo_1.AutoSize = true;
            this.lblMemo_1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMemo_1.Location = new System.Drawing.Point(100, 10);
            this.lblMemo_1.Name = "lblMemo_1";
            this.lblMemo_1.Size = new System.Drawing.Size(157, 17);
            this.lblMemo_1.TabIndex = 10;
            this.lblMemo_1.Text = "제품을 등록하겠습니다.";
            // 
            // lblMemo_2
            // 
            this.lblMemo_2.AutoSize = true;
            this.lblMemo_2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMemo_2.Location = new System.Drawing.Point(91, 35);
            this.lblMemo_2.Name = "lblMemo_2";
            this.lblMemo_2.Size = new System.Drawing.Size(175, 17);
            this.lblMemo_2.TabIndex = 11;
            this.lblMemo_2.Text = "카메라 인식을 확인합니다.";
            // 
            // lblMemo_3
            // 
            this.lblMemo_3.AutoSize = true;
            this.lblMemo_3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMemo_3.Location = new System.Drawing.Point(36, 61);
            this.lblMemo_3.Name = "lblMemo_3";
            this.lblMemo_3.Size = new System.Drawing.Size(276, 17);
            this.lblMemo_3.TabIndex = 12;
            this.lblMemo_3.Text = "이상이 없는 경우, 다음 버튼을 눌러주세요.";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(21, 89);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(315, 35);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "다음(N)";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrev.Location = new System.Drawing.Point(21, 237);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(315, 35);
            this.btnPrev.TabIndex = 14;
            this.btnPrev.Text = "이전(P)";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lblMemo_4
            // 
            this.lblMemo_4.AutoSize = true;
            this.lblMemo_4.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMemo_4.Location = new System.Drawing.Point(36, 212);
            this.lblMemo_4.Name = "lblMemo_4";
            this.lblMemo_4.Size = new System.Drawing.Size(276, 17);
            this.lblMemo_4.TabIndex = 15;
            this.lblMemo_4.Text = "이상이 있는 경우, 이전 버튼을 눌러주세요.";
            // 
            // panelFuncBox
            // 
            this.panelFuncBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFuncBox.Controls.Add(this.btnZoomUp);
            this.panelFuncBox.Controls.Add(this.lblMemo_1);
            this.panelFuncBox.Controls.Add(this.lblMemo_4);
            this.panelFuncBox.Controls.Add(this.lblMemo_2);
            this.panelFuncBox.Controls.Add(this.btnPrev);
            this.panelFuncBox.Controls.Add(this.lblMemo_3);
            this.panelFuncBox.Controls.Add(this.btnNext);
            this.panelFuncBox.Location = new System.Drawing.Point(431, 119);
            this.panelFuncBox.Name = "panelFuncBox";
            this.panelFuncBox.Size = new System.Drawing.Size(357, 286);
            this.panelFuncBox.TabIndex = 16;
            // 
            // btnZoomUp
            // 
            this.btnZoomUp.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnZoomUp.Location = new System.Drawing.Point(21, 133);
            this.btnZoomUp.Name = "btnZoomUp";
            this.btnZoomUp.Size = new System.Drawing.Size(315, 35);
            this.btnZoomUp.TabIndex = 16;
            this.btnZoomUp.Text = "확대(Z)";
            this.btnZoomUp.UseVisualStyleBackColor = true;
            this.btnZoomUp.Click += new System.EventHandler(this.btnZoomUp_Click);
            // 
            // lblTxtProjectId
            // 
            this.lblTxtProjectId.AutoSize = true;
            this.lblTxtProjectId.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTxtProjectId.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTxtProjectId.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTxtProjectId.Location = new System.Drawing.Point(12, 9);
            this.lblTxtProjectId.Name = "lblTxtProjectId";
            this.lblTxtProjectId.Size = new System.Drawing.Size(43, 15);
            this.lblTxtProjectId.TabIndex = 17;
            this.lblTxtProjectId.Text = "품목명";
            // 
            // lblTxtProjectName
            // 
            this.lblTxtProjectName.AutoSize = true;
            this.lblTxtProjectName.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTxtProjectName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTxtProjectName.Location = new System.Drawing.Point(12, 26);
            this.lblTxtProjectName.Name = "lblTxtProjectName";
            this.lblTxtProjectName.Size = new System.Drawing.Size(43, 15);
            this.lblTxtProjectName.TabIndex = 18;
            this.lblTxtProjectName.Text = "품목명";
            // 
            // lblTxtDescription
            // 
            this.lblTxtDescription.AutoSize = true;
            this.lblTxtDescription.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTxtDescription.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTxtDescription.Location = new System.Drawing.Point(12, 44);
            this.lblTxtDescription.Name = "lblTxtDescription";
            this.lblTxtDescription.Size = new System.Drawing.Size(43, 15);
            this.lblTxtDescription.TabIndex = 19;
            this.lblTxtDescription.Text = "품목명";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Location = new System.Drawing.Point(12, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 41);
            this.panel1.TabIndex = 20;
            // 
            // ProductCameraTestFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTxtDescription);
            this.Controls.Add(this.lblTxtProjectName);
            this.Controls.Add(this.lblTxtProjectId);
            this.Controls.Add(this.panelFuncBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductCameraTestFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "제품등록 / 3단계 - 카메라 테스트";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductCameraTest_FormClosing);
            this.Load += new System.EventHandler(this.ProductCameraTest_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductCameraTest_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelFuncBox.ResumeLayout(false);
            this.panelFuncBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private TextBox txtProductName;
        private Label lblProductName;
        private PictureBox pictureBox1;
        private Label lblMemo_1;
        private Label lblMemo_2;
        private Label lblMemo_3;
        private Button btnNext;
        private Button btnPrev;
        private Label lblMemo_4;
        private Panel panelFuncBox;
        private Label lblTxtProjectId;
        private Label lblTxtProjectName;
        private Label lblTxtDescription;
        private Button btnZoomUp;
        private Panel panel1;
    }
}