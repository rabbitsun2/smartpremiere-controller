namespace SmartLogistics
{
    partial class ProductRegisterFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductRegisterFrm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.panelInputBox = new System.Windows.Forms.Panel();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.txtProjectId = new System.Windows.Forms.TextBox();
            this.lblProjectId = new System.Windows.Forms.Label();
            this.lblRecv = new System.Windows.Forms.Label();
            this.lbRecvData = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.panelInputBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(354, 52);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(110, 24);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "제품 / 등록";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductName.Location = new System.Drawing.Point(98, 78);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(43, 15);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "품목명";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductName.Location = new System.Drawing.Point(183, 75);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(238, 22);
            this.txtProductName.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescription.Location = new System.Drawing.Point(183, 104);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(238, 22);
            this.txtDescription.TabIndex = 4;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(98, 107);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(31, 15);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "설명";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(98, 136);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(323, 38);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "다음(N)";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panelInputBox
            // 
            this.panelInputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInputBox.Controls.Add(this.txtProjectName);
            this.panelInputBox.Controls.Add(this.lblProjectName);
            this.panelInputBox.Controls.Add(this.txtProjectId);
            this.panelInputBox.Controls.Add(this.lblProjectId);
            this.panelInputBox.Controls.Add(this.txtProductName);
            this.panelInputBox.Controls.Add(this.btnNext);
            this.panelInputBox.Controls.Add(this.lblProductName);
            this.panelInputBox.Controls.Add(this.txtDescription);
            this.panelInputBox.Controls.Add(this.lblDescription);
            this.panelInputBox.Location = new System.Drawing.Point(149, 103);
            this.panelInputBox.Name = "panelInputBox";
            this.panelInputBox.Size = new System.Drawing.Size(499, 187);
            this.panelInputBox.TabIndex = 9;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProjectName.Location = new System.Drawing.Point(183, 48);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.ReadOnly = true;
            this.txtProjectName.Size = new System.Drawing.Size(238, 22);
            this.txtProjectName.TabIndex = 2;
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProjectName.Location = new System.Drawing.Point(98, 51);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(67, 15);
            this.lblProjectName.TabIndex = 11;
            this.lblProjectName.Text = "프로젝트명";
            // 
            // txtProjectId
            // 
            this.txtProjectId.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProjectId.Location = new System.Drawing.Point(183, 21);
            this.txtProjectId.Name = "txtProjectId";
            this.txtProjectId.ReadOnly = true;
            this.txtProjectId.Size = new System.Drawing.Size(238, 22);
            this.txtProjectId.TabIndex = 1;
            // 
            // lblProjectId
            // 
            this.lblProjectId.AutoSize = true;
            this.lblProjectId.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProjectId.Location = new System.Drawing.Point(98, 24);
            this.lblProjectId.Name = "lblProjectId";
            this.lblProjectId.Size = new System.Drawing.Size(79, 15);
            this.lblProjectId.TabIndex = 9;
            this.lblProjectId.Text = "프로젝트번호";
            // 
            // lblRecv
            // 
            this.lblRecv.AutoSize = true;
            this.lblRecv.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRecv.Location = new System.Drawing.Point(3, 9);
            this.lblRecv.Name = "lblRecv";
            this.lblRecv.Size = new System.Drawing.Size(39, 15);
            this.lblRecv.TabIndex = 9;
            this.lblRecv.Text = "label4";
            // 
            // lbRecvData
            // 
            this.lbRecvData.AutoSize = true;
            this.lbRecvData.ForeColor = System.Drawing.SystemColors.Control;
            this.lbRecvData.Location = new System.Drawing.Point(0, 0);
            this.lbRecvData.Name = "lbRecvData";
            this.lbRecvData.Size = new System.Drawing.Size(39, 15);
            this.lbRecvData.TabIndex = 10;
            this.lbRecvData.Text = "label4";
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrev.Location = new System.Drawing.Point(700, 15);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(86, 28);
            this.btnPrev.TabIndex = 11;
            this.btnPrev.Text = "이전(P)";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // ProductRegisterFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.lbRecvData);
            this.Controls.Add(this.lblRecv);
            this.Controls.Add(this.panelInputBox);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductRegisterFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "제품등록 / 2단계 - 제품 정보 입력";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductRegisterFrm_FormClosing);
            this.Load += new System.EventHandler(this.ProductRegisterFrm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductRegisterFrm_KeyDown);
            this.panelInputBox.ResumeLayout(false);
            this.panelInputBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Label lblProductName;
        private TextBox txtProductName;
        private TextBox txtDescription;
        private Label lblDescription;
        private Button btnNext;
        private Panel panelInputBox;
        private Label lblRecv;
        private Label lbRecvData;
        private TextBox txtProjectName;
        private Label lblProjectName;
        private TextBox txtProjectId;
        private Label lblProjectId;
        private Button btnPrev;
    }
}