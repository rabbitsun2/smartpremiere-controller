namespace SmartLogistics
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMenu_1 = new System.Windows.Forms.Button();
            this.btnMenu_2 = new System.Windows.Forms.Button();
            this.btnMenu_4 = new System.Windows.Forms.Button();
            this.btnMenu_3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Smart Premiere";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Controller";
            // 
            // btnMenu_1
            // 
            this.btnMenu_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMenu_1.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenu_1.Location = new System.Drawing.Point(12, 13);
            this.btnMenu_1.Name = "btnMenu_1";
            this.btnMenu_1.Size = new System.Drawing.Size(103, 86);
            this.btnMenu_1.TabIndex = 2;
            this.btnMenu_1.Text = "제품";
            this.btnMenu_1.UseVisualStyleBackColor = false;
            this.btnMenu_1.Click += new System.EventHandler(this.btnMenu_1_Click);
            // 
            // btnMenu_2
            // 
            this.btnMenu_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMenu_2.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenu_2.Location = new System.Drawing.Point(132, 13);
            this.btnMenu_2.Name = "btnMenu_2";
            this.btnMenu_2.Size = new System.Drawing.Size(103, 86);
            this.btnMenu_2.TabIndex = 3;
            this.btnMenu_2.Text = "창고";
            this.btnMenu_2.UseVisualStyleBackColor = false;
            // 
            // btnMenu_4
            // 
            this.btnMenu_4.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenu_4.Location = new System.Drawing.Point(132, 115);
            this.btnMenu_4.Name = "btnMenu_4";
            this.btnMenu_4.Size = new System.Drawing.Size(103, 86);
            this.btnMenu_4.TabIndex = 5;
            this.btnMenu_4.Text = "정보";
            this.btnMenu_4.UseVisualStyleBackColor = true;
            this.btnMenu_4.Click += new System.EventHandler(this.btnMenu_4_Click);
            // 
            // btnMenu_3
            // 
            this.btnMenu_3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMenu_3.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenu_3.Location = new System.Drawing.Point(12, 115);
            this.btnMenu_3.Name = "btnMenu_3";
            this.btnMenu_3.Size = new System.Drawing.Size(103, 86);
            this.btnMenu_3.TabIndex = 4;
            this.btnMenu_3.Text = "물류/생산";
            this.btnMenu_3.UseVisualStyleBackColor = false;
            this.btnMenu_3.Click += new System.EventHandler(this.btnMenu_3_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnMenu_4);
            this.panel1.Controls.Add(this.btnMenu_1);
            this.panel1.Controls.Add(this.btnMenu_2);
            this.panel1.Controls.Add(this.btnMenu_3);
            this.panel1.Location = new System.Drawing.Point(288, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 214);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "제품 등록과 관리 기능을 선택할 수 있습니다.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(24, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "AI 기반으로 창고를 제어할 수 있습니다.";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Premiere Controller ver 0.2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnMenu_1;
        private Button btnMenu_2;
        private Button btnMenu_4;
        private Button btnMenu_3;
        private Panel panel1;
        private Label label3;
        private Label label4;
    }
}