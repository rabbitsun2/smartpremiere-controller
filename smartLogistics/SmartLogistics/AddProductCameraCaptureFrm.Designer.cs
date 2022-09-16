namespace SmartLogistics
{
    partial class AddProductCameraCaptureFrm
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
            this.btnPrev = new System.Windows.Forms.Button();
            this.lblUUID = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.Label();
            this.txtProjectId = new System.Windows.Forms.Label();
            this.lblEndNum = new System.Windows.Forms.Label();
            this.panelDetailBox = new System.Windows.Forms.Panel();
            this.lblPer = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblStartNum = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnZoomUp = new System.Windows.Forms.Button();
            this.panelFuncBox = new System.Windows.Forms.Panel();
            this.btnCheese = new System.Windows.Forms.Button();
            this.lblMemo_2 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblMemo_1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTxtUUID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtUuid = new System.Windows.Forms.Label();
            this.panelDetailBox.SuspendLayout();
            this.panelFuncBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrev.Location = new System.Drawing.Point(694, 29);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 34);
            this.btnPrev.TabIndex = 36;
            this.btnPrev.Text = "이전";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lblUUID
            // 
            this.lblUUID.AutoSize = true;
            this.lblUUID.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUUID.Location = new System.Drawing.Point(32, 65);
            this.lblUUID.Name = "lblUUID";
            this.lblUUID.Size = new System.Drawing.Size(37, 14);
            this.lblUUID.TabIndex = 34;
            this.lblUUID.Text = "UUID";
            // 
            // txtProductId
            // 
            this.txtProductId.AutoSize = true;
            this.txtProductId.ForeColor = System.Drawing.SystemColors.Control;
            this.txtProductId.Location = new System.Drawing.Point(7, 23);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(39, 15);
            this.txtProductId.TabIndex = 32;
            this.txtProductId.Text = "label7";
            // 
            // txtProjectId
            // 
            this.txtProjectId.AutoSize = true;
            this.txtProjectId.ForeColor = System.Drawing.SystemColors.Control;
            this.txtProjectId.Location = new System.Drawing.Point(7, 8);
            this.txtProjectId.Name = "txtProjectId";
            this.txtProjectId.Size = new System.Drawing.Size(39, 15);
            this.txtProjectId.TabIndex = 31;
            this.txtProjectId.Text = "label6";
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
            // panelDetailBox
            // 
            this.panelDetailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDetailBox.Controls.Add(this.lblEndNum);
            this.panelDetailBox.Controls.Add(this.lblPer);
            this.panelDetailBox.Controls.Add(this.lblProductName);
            this.panelDetailBox.Controls.Add(this.lblStartNum);
            this.panelDetailBox.Controls.Add(this.txtProductName);
            this.panelDetailBox.Location = new System.Drawing.Point(32, 99);
            this.panelDetailBox.Name = "panelDetailBox";
            this.panelDetailBox.Size = new System.Drawing.Size(737, 79);
            this.panelDetailBox.TabIndex = 30;
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
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductName.Location = new System.Drawing.Point(78, 45);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(258, 22);
            this.txtProductName.TabIndex = 11;
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
            // panelFuncBox
            // 
            this.panelFuncBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFuncBox.Controls.Add(this.btnZoomUp);
            this.panelFuncBox.Controls.Add(this.btnCheese);
            this.panelFuncBox.Controls.Add(this.lblMemo_2);
            this.panelFuncBox.Controls.Add(this.btnNext);
            this.panelFuncBox.Controls.Add(this.lblMemo_1);
            this.panelFuncBox.Location = new System.Drawing.Point(423, 198);
            this.panelFuncBox.Name = "panelFuncBox";
            this.panelFuncBox.Size = new System.Drawing.Size(346, 240);
            this.panelFuncBox.TabIndex = 29;
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
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(32, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 240);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // lblTxtUUID
            // 
            this.lblTxtUUID.AutoSize = true;
            this.lblTxtUUID.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTxtUUID.Location = new System.Drawing.Point(89, 65);
            this.lblTxtUUID.Name = "lblTxtUUID";
            this.lblTxtUUID.Size = new System.Drawing.Size(41, 14);
            this.lblTxtUUID.TabIndex = 35;
            this.lblTxtUUID.Text = "label6";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(348, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(96, 24);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.Text = "제품 촬영";
            // 
            // txtUuid
            // 
            this.txtUuid.AutoSize = true;
            this.txtUuid.ForeColor = System.Drawing.SystemColors.Control;
            this.txtUuid.Location = new System.Drawing.Point(7, 37);
            this.txtUuid.Name = "txtUuid";
            this.txtUuid.Size = new System.Drawing.Size(39, 15);
            this.txtUuid.TabIndex = 37;
            this.txtUuid.Text = "label7";
            // 
            // AddProductCameraCaptureFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.txtUuid);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.lblUUID);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.txtProjectId);
            this.Controls.Add(this.panelDetailBox);
            this.Controls.Add(this.panelFuncBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTxtUUID);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProductCameraCaptureFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "여분 촬영";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddProductCameraCaptureFrm_FormClosing);
            this.Load += new System.EventHandler(this.AddProductCameraCaptureFrm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddProductCameraCaptureFrm_KeyDown);
            this.panelDetailBox.ResumeLayout(false);
            this.panelDetailBox.PerformLayout();
            this.panelFuncBox.ResumeLayout(false);
            this.panelFuncBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPrev;
        private Label lblUUID;
        private Label txtProductId;
        private Label txtProjectId;
        private Label lblEndNum;
        private Panel panelDetailBox;
        private Label lblPer;
        private Label lblProductName;
        private Label lblStartNum;
        private TextBox txtProductName;
        private Button btnZoomUp;
        private Panel panelFuncBox;
        private Button btnCheese;
        private Label lblMemo_2;
        private Button btnNext;
        private Label lblMemo_1;
        private PictureBox pictureBox1;
        private Label lblTxtUUID;
        private Label lblTitle;
        private Label txtUuid;
    }
}