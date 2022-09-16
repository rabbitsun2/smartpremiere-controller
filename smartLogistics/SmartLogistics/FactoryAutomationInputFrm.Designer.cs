namespace SmartLogistics
{
    partial class FactoryAutomationInputFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTxtUUID = new System.Windows.Forms.Label();
            this.lblUUID = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(15, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 400);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(19, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(617, 359);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Automation System";
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrev.Location = new System.Drawing.Point(944, 21);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(92, 33);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "이전(P)";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTxtUUID);
            this.panel2.Controls.Add(this.lblUUID);
            this.panel2.Location = new System.Drawing.Point(15, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(655, 28);
            this.panel2.TabIndex = 3;
            // 
            // lblTxtUUID
            // 
            this.lblTxtUUID.AutoSize = true;
            this.lblTxtUUID.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTxtUUID.Location = new System.Drawing.Point(147, 7);
            this.lblTxtUUID.Name = "lblTxtUUID";
            this.lblTxtUUID.Size = new System.Drawing.Size(37, 14);
            this.lblTxtUUID.TabIndex = 1;
            this.lblTxtUUID.Text = "UUID";
            // 
            // lblUUID
            // 
            this.lblUUID.AutoSize = true;
            this.lblUUID.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUUID.Location = new System.Drawing.Point(9, 7);
            this.lblUUID.Name = "lblUUID";
            this.lblUUID.Size = new System.Drawing.Size(37, 14);
            this.lblUUID.TabIndex = 0;
            this.lblUUID.Text = "UUID";
            // 
            // FactoryAutomationInputFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 626);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FactoryAutomationInputFrm";
            this.Text = "AI - Factory Automation System - Receiving";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FactoryAutomationInputFrm_FormClosing);
            this.Load += new System.EventHandler(this.FactoryAutomationInputFrm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnPrev;
        private Panel panel2;
        private Label lblUUID;
        private Label lblTxtUUID;
        private ColorDialog colorDialog1;
    }
}