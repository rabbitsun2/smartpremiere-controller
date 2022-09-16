namespace SmartLogistics
{
    partial class FaMainFrm
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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblMemo_1 = new System.Windows.Forms.Label();
            this.btnLogo = new System.Windows.Forms.Button();
            this.btnCreateModel = new System.Windows.Forms.Button();
            this.panelFuncBox = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRobotArmController = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMachineMgt = new System.Windows.Forms.Button();
            this.btnBarcodeQR = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFAInput = new System.Windows.Forms.Button();
            this.btnFAOutput = new System.Windows.Forms.Button();
            this.panelLogo.SuspendLayout();
            this.panelFuncBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogo.Controls.Add(this.lblMemo_1);
            this.panelLogo.Controls.Add(this.btnLogo);
            this.panelLogo.Location = new System.Drawing.Point(22, 61);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(287, 297);
            this.panelLogo.TabIndex = 0;
            // 
            // lblMemo_1
            // 
            this.lblMemo_1.AutoSize = true;
            this.lblMemo_1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMemo_1.Location = new System.Drawing.Point(20, 101);
            this.lblMemo_1.Name = "lblMemo_1";
            this.lblMemo_1.Size = new System.Drawing.Size(220, 15);
            this.lblMemo_1.TabIndex = 1;
            this.lblMemo_1.Text = "물류 / 생산 흐름을 제어할 수 있습니다.";
            // 
            // btnLogo
            // 
            this.btnLogo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogo.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogo.Location = new System.Drawing.Point(15, 16);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(119, 64);
            this.btnLogo.TabIndex = 0;
            this.btnLogo.Text = "물류/생산";
            this.btnLogo.UseVisualStyleBackColor = false;
            // 
            // btnCreateModel
            // 
            this.btnCreateModel.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateModel.Location = new System.Drawing.Point(16, 47);
            this.btnCreateModel.Name = "btnCreateModel";
            this.btnCreateModel.Size = new System.Drawing.Size(158, 33);
            this.btnCreateModel.TabIndex = 1;
            this.btnCreateModel.Text = "모델 학습";
            this.btnCreateModel.UseVisualStyleBackColor = true;
            this.btnCreateModel.Click += new System.EventHandler(this.btnCreateModel_Click);
            // 
            // panelFuncBox
            // 
            this.panelFuncBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFuncBox.Controls.Add(this.btnFAOutput);
            this.panelFuncBox.Controls.Add(this.label3);
            this.panelFuncBox.Controls.Add(this.btnFAInput);
            this.panelFuncBox.Controls.Add(this.label2);
            this.panelFuncBox.Controls.Add(this.btnRobotArmController);
            this.panelFuncBox.Controls.Add(this.label1);
            this.panelFuncBox.Controls.Add(this.btnMachineMgt);
            this.panelFuncBox.Controls.Add(this.btnBarcodeQR);
            this.panelFuncBox.Controls.Add(this.btnCreateModel);
            this.panelFuncBox.Location = new System.Drawing.Point(337, 61);
            this.panelFuncBox.Name = "panelFuncBox";
            this.panelFuncBox.Size = new System.Drawing.Size(437, 297);
            this.panelFuncBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(192, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "로봇팔";
            // 
            // btnRobotArmController
            // 
            this.btnRobotArmController.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRobotArmController.Location = new System.Drawing.Point(192, 47);
            this.btnRobotArmController.Name = "btnRobotArmController";
            this.btnRobotArmController.Size = new System.Drawing.Size(141, 33);
            this.btnRobotArmController.TabIndex = 5;
            this.btnRobotArmController.Text = "로봇팔 제어(기본)";
            this.btnRobotArmController.UseVisualStyleBackColor = true;
            this.btnRobotArmController.Click += new System.EventHandler(this.btnRobotArmController_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "기능";
            // 
            // btnMachineMgt
            // 
            this.btnMachineMgt.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMachineMgt.Location = new System.Drawing.Point(16, 125);
            this.btnMachineMgt.Name = "btnMachineMgt";
            this.btnMachineMgt.Size = new System.Drawing.Size(158, 33);
            this.btnMachineMgt.TabIndex = 3;
            this.btnMachineMgt.Text = "장비 관리";
            this.btnMachineMgt.UseVisualStyleBackColor = true;
            this.btnMachineMgt.Click += new System.EventHandler(this.btnMachineMgt_Click);
            // 
            // btnBarcodeQR
            // 
            this.btnBarcodeQR.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBarcodeQR.Location = new System.Drawing.Point(16, 86);
            this.btnBarcodeQR.Name = "btnBarcodeQR";
            this.btnBarcodeQR.Size = new System.Drawing.Size(158, 33);
            this.btnBarcodeQR.TabIndex = 2;
            this.btnBarcodeQR.Text = "캠 바코드/QR코드 인식";
            this.btnBarcodeQR.UseVisualStyleBackColor = true;
            this.btnBarcodeQR.Click += new System.EventHandler(this.btnBarcodeQR_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrev.Location = new System.Drawing.Point(683, 18);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(91, 28);
            this.btnPrev.TabIndex = 3;
            this.btnPrev.Text = "이전";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "물류/생산";
            // 
            // btnFAInput
            // 
            this.btnFAInput.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFAInput.Location = new System.Drawing.Point(16, 205);
            this.btnFAInput.Name = "btnFAInput";
            this.btnFAInput.Size = new System.Drawing.Size(158, 33);
            this.btnFAInput.TabIndex = 7;
            this.btnFAInput.Text = "입고";
            this.btnFAInput.UseVisualStyleBackColor = true;
            this.btnFAInput.Click += new System.EventHandler(this.btnFAInput_Click);
            // 
            // btnFAOutput
            // 
            this.btnFAOutput.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFAOutput.Location = new System.Drawing.Point(16, 245);
            this.btnFAOutput.Name = "btnFAOutput";
            this.btnFAOutput.Size = new System.Drawing.Size(158, 33);
            this.btnFAOutput.TabIndex = 9;
            this.btnFAOutput.Text = "출고";
            this.btnFAOutput.UseVisualStyleBackColor = true;
            // 
            // FaMainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 384);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.panelFuncBox);
            this.Controls.Add(this.panelLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FaMainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "물류/생산::: 메뉴";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FaMainFrm_FormClosing);
            this.Load += new System.EventHandler(this.FaMainFrm_Load);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelFuncBox.ResumeLayout(false);
            this.panelFuncBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelLogo;
        private Button btnLogo;
        private Label lblMemo_1;
        private Button btnCreateModel;
        private Panel panelFuncBox;
        private Button btnPrev;
        private Button btnBarcodeQR;
        private Button btnMachineMgt;
        private Label label1;
        private Button btnRobotArmController;
        private Label label2;
        private Label label3;
        private Button btnFAInput;
        private Button btnFAOutput;
    }
}