namespace SmartLogistics
{
    partial class ProductCameraCaptureFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCameraCaptureFrm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMemo_2 = new System.Windows.Forms.Label();
            this.lblMemo_1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCheese = new System.Windows.Forms.Button();
            this.panelFuncBox = new System.Windows.Forms.Panel();
            this.btnZoomUp = new System.Windows.Forms.Button();
            this.lblStartNum = new System.Windows.Forms.Label();
            this.lblPer = new System.Windows.Forms.Label();
            this.panelDetailBox = new System.Windows.Forms.Panel();
            this.lblEndNum = new System.Windows.Forms.Label();
            this.txtProjectId = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.Label();
            this.lblUUID = new System.Windows.Forms.Label();
            this.lblTxtUUID = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelFuncBox.SuspendLayout();
            this.panelDetailBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(346, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(96, 24);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "제품 촬영";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductName.Location = new System.Drawing.Point(78, 45);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(258, 22);
            this.txtProductName.TabIndex = 11;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductName.Location = new System.Drawing.Point(13, 48);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(43, 15);
            this.lblProductName.TabIndex = 10;
            this.lblProductName.Text = "품목명";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(30, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 240);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lblMemo_2
            // 
            this.lblMemo_2.AutoSize = true;
            this.lblMemo_2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMemo_2.Location = new System.Drawing.Point(103, 53);
            this.lblMemo_2.Name = "lblMemo_2";
            this.lblMemo_2.Size = new System.Drawing.Size(143, 17);
            this.lblMemo_2.TabIndex = 14;
            this.lblMemo_2.Text = "다각도로 움직이세요.";
            // 
            // lblMemo_1
            // 
            this.lblMemo_1.AutoSize = true;
            this.lblMemo_1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMemo_1.Location = new System.Drawing.Point(98, 25);
            this.lblMemo_1.Name = "lblMemo_1";
            this.lblMemo_1.Size = new System.Drawing.Size(157, 17);
            this.lblMemo_1.TabIndex = 13;
            this.lblMemo_1.Text = "제품을 촬영하겠습니다.";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(16, 170);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(311, 32);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "다음(N)";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCheese
            // 
            this.btnCheese.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheese.Location = new System.Drawing.Point(16, 94);
            this.btnCheese.Name = "btnCheese";
            this.btnCheese.Size = new System.Drawing.Size(311, 32);
            this.btnCheese.TabIndex = 1;
            this.btnCheese.Text = "치즈(C)";
            this.btnCheese.UseVisualStyleBackColor = true;
            this.btnCheese.Click += new System.EventHandler(this.btnCheese_Click);
            // 
            // panelFuncBox
            // 
            this.panelFuncBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFuncBox.Controls.Add(this.btnZoomUp);
            this.panelFuncBox.Controls.Add(this.btnCheese);
            this.panelFuncBox.Controls.Add(this.lblMemo_2);
            this.panelFuncBox.Controls.Add(this.btnNext);
            this.panelFuncBox.Controls.Add(this.lblMemo_1);
            this.panelFuncBox.Location = new System.Drawing.Point(421, 192);
            this.panelFuncBox.Name = "panelFuncBox";
            this.panelFuncBox.Size = new System.Drawing.Size(346, 240);
            this.panelFuncBox.TabIndex = 17;
            // 
            // btnZoomUp
            // 
            this.btnZoomUp.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnZoomUp.Location = new System.Drawing.Point(16, 132);
            this.btnZoomUp.Name = "btnZoomUp";
            this.btnZoomUp.Size = new System.Drawing.Size(311, 32);
            this.btnZoomUp.TabIndex = 15;
            this.btnZoomUp.Text = "확대(Z)";
            this.btnZoomUp.UseVisualStyleBackColor = true;
            this.btnZoomUp.Click += new System.EventHandler(this.btnZoomUp_Click);
            // 
            // lblStartNum
            // 
            this.lblStartNum.AutoSize = true;
            this.lblStartNum.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStartNum.Location = new System.Drawing.Point(13, 9);
            this.lblStartNum.Name = "lblStartNum";
            this.lblStartNum.Size = new System.Drawing.Size(17, 17);
            this.lblStartNum.TabIndex = 18;
            this.lblStartNum.Text = "0";
            // 
            // lblPer
            // 
            this.lblPer.AutoSize = true;
            this.lblPer.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPer.Location = new System.Drawing.Point(60, 9);
            this.lblPer.Name = "lblPer";
            this.lblPer.Size = new System.Drawing.Size(14, 17);
            this.lblPer.TabIndex = 19;
            this.lblPer.Text = "/";
            // 
            // panelDetailBox
            // 
            this.panelDetailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDetailBox.Controls.Add(this.lblEndNum);
            this.panelDetailBox.Controls.Add(this.lblPer);
            this.panelDetailBox.Controls.Add(this.lblProductName);
            this.panelDetailBox.Controls.Add(this.lblStartNum);
            this.panelDetailBox.Controls.Add(this.txtProductName);
            this.panelDetailBox.Location = new System.Drawing.Point(30, 103);
            this.panelDetailBox.Name = "panelDetailBox";
            this.panelDetailBox.Size = new System.Drawing.Size(737, 79);
            this.panelDetailBox.TabIndex = 20;
            // 
            // lblEndNum
            // 
            this.lblEndNum.AutoSize = true;
            this.lblEndNum.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEndNum.Location = new System.Drawing.Point(94, 9);
            this.lblEndNum.Name = "lblEndNum";
            this.lblEndNum.Size = new System.Drawing.Size(26, 17);
            this.lblEndNum.TabIndex = 20;
            this.lblEndNum.Text = "30";
            // 
            // txtProjectId
            // 
            this.txtProjectId.AutoSize = true;
            this.txtProjectId.ForeColor = System.Drawing.SystemColors.Control;
            this.txtProjectId.Location = new System.Drawing.Point(5, 2);
            this.txtProjectId.Name = "txtProjectId";
            this.txtProjectId.Size = new System.Drawing.Size(39, 15);
            this.txtProjectId.TabIndex = 21;
            this.txtProjectId.Text = "label6";
            // 
            // txtProjectName
            // 
            this.txtProjectName.AutoSize = true;
            this.txtProjectName.ForeColor = System.Drawing.SystemColors.Control;
            this.txtProjectName.Location = new System.Drawing.Point(5, 17);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(39, 15);
            this.txtProjectName.TabIndex = 22;
            this.txtProjectName.Text = "label7";
            // 
            // txtDescription
            // 
            this.txtDescription.AutoSize = true;
            this.txtDescription.ForeColor = System.Drawing.SystemColors.Control;
            this.txtDescription.Location = new System.Drawing.Point(5, 31);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(39, 15);
            this.txtDescription.TabIndex = 23;
            this.txtDescription.Text = "label8";
            // 
            // lblUUID
            // 
            this.lblUUID.AutoSize = true;
            this.lblUUID.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUUID.Location = new System.Drawing.Point(12, 6);
            this.lblUUID.Name = "lblUUID";
            this.lblUUID.Size = new System.Drawing.Size(37, 14);
            this.lblUUID.TabIndex = 24;
            this.lblUUID.Text = "UUID";
            // 
            // lblTxtUUID
            // 
            this.lblTxtUUID.AutoSize = true;
            this.lblTxtUUID.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTxtUUID.Location = new System.Drawing.Point(69, 6);
            this.lblTxtUUID.Name = "lblTxtUUID";
            this.lblTxtUUID.Size = new System.Drawing.Size(41, 14);
            this.lblTxtUUID.TabIndex = 25;
            this.lblTxtUUID.Text = "label6";
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrev.Location = new System.Drawing.Point(692, 23);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 34);
            this.btnPrev.TabIndex = 26;
            this.btnPrev.Text = "이전(P)";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblUUID);
            this.panel1.Controls.Add(this.lblTxtUUID);
            this.panel1.Location = new System.Drawing.Point(30, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 28);
            this.panel1.TabIndex = 27;
            // 
            // ProductCameraCaptureFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.txtProjectId);
            this.Controls.Add(this.panelDetailBox);
            this.Controls.Add(this.panelFuncBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductCameraCaptureFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "제품등록 / 4단계 - 제품 촬영";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductCameraCaptureFrm_FormClosing);
            this.Load += new System.EventHandler(this.ProductCameraCaptureFrm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductCameraCaptureFrm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelFuncBox.ResumeLayout(false);
            this.panelFuncBox.PerformLayout();
            this.panelDetailBox.ResumeLayout(false);
            this.panelDetailBox.PerformLayout();
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
        private Label lblMemo_2;
        private Label lblMemo_1;
        private Button btnNext;
        private Button btnCheese;
        private Panel panelFuncBox;
        private Label lblStartNum;
        private Label lblPer;
        private Panel panelDetailBox;
        private Label txtProjectId;
        private Label txtProjectName;
        private Label txtDescription;
        private Label lblUUID;
        private Label lblTxtUUID;
        private Label lblEndNum;
        private Button btnZoomUp;
        private Button btnPrev;
        private Panel panel1;
    }
}