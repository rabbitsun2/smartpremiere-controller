namespace SmartLogistics
{
    partial class BarcodeQRRecognizeFrm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.lblDialog = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtWarehouse_regidate = new System.Windows.Forms.TextBox();
            this.txtWarehouse_current_cnt = new System.Windows.Forms.TextBox();
            this.txtWarehouse_barcode_qr = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtBoxspec_boxname = new System.Windows.Forms.TextBox();
            this.txtBoxspec_height = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBoxspec_length = new System.Windows.Forms.TextBox();
            this.txtBoxspec_width = new System.Windows.Forms.TextBox();
            this.txtBoxspec_type_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtProduct_regidate = new System.Windows.Forms.TextBox();
            this.txtProduct_name = new System.Windows.Forms.TextBox();
            this.txtProduct_barcode_qr = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel_result = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_result_print = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel_result.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(10, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 270);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(14, 47);
            this.txtBarcode.Multiline = true;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(377, 93);
            this.txtBarcode.TabIndex = 1;
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrev.Location = new System.Drawing.Point(793, 15);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(86, 30);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "이전(P)";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lblDialog
            // 
            this.lblDialog.AutoSize = true;
            this.lblDialog.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDialog.Location = new System.Drawing.Point(14, 20);
            this.lblDialog.Name = "lblDialog";
            this.lblDialog.Size = new System.Drawing.Size(47, 15);
            this.lblDialog.TabIndex = 3;
            this.lblDialog.Text = "대화 창";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblDialog);
            this.panel1.Controls.Add(this.txtBarcode);
            this.panel1.Location = new System.Drawing.Point(474, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 155);
            this.panel1.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(21, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(160, 21);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "바코드 및 QR 인식";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(12, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 294);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(12, 365);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(867, 29);
            this.panel3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "OpenCV와 ZXing 라이브러리를 적용하여 바코드 및 QR인식을 카메라로 동작하도록 구현하였습니다.";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(12, 403);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(867, 219);
            this.panel4.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.txtWarehouse_regidate);
            this.panel7.Controls.Add(this.txtWarehouse_current_cnt);
            this.panel7.Controls.Add(this.txtWarehouse_barcode_qr);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.label18);
            this.panel7.Location = new System.Drawing.Point(558, 36);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(273, 173);
            this.panel7.TabIndex = 22;
            // 
            // txtWarehouse_regidate
            // 
            this.txtWarehouse_regidate.Location = new System.Drawing.Point(109, 88);
            this.txtWarehouse_regidate.Name = "txtWarehouse_regidate";
            this.txtWarehouse_regidate.Size = new System.Drawing.Size(145, 23);
            this.txtWarehouse_regidate.TabIndex = 17;
            // 
            // txtWarehouse_current_cnt
            // 
            this.txtWarehouse_current_cnt.Location = new System.Drawing.Point(109, 62);
            this.txtWarehouse_current_cnt.Name = "txtWarehouse_current_cnt";
            this.txtWarehouse_current_cnt.Size = new System.Drawing.Size(145, 23);
            this.txtWarehouse_current_cnt.TabIndex = 16;
            // 
            // txtWarehouse_barcode_qr
            // 
            this.txtWarehouse_barcode_qr.Location = new System.Drawing.Point(109, 36);
            this.txtWarehouse_barcode_qr.Name = "txtWarehouse_barcode_qr";
            this.txtWarehouse_barcode_qr.Size = new System.Drawing.Size(145, 23);
            this.txtWarehouse_barcode_qr.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(13, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 17);
            this.label15.TabIndex = 14;
            this.label15.Text = "창고 정보";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(13, 40);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 14);
            this.label16.TabIndex = 13;
            this.label16.Text = "바코드/QR코드";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(13, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 14);
            this.label17.TabIndex = 11;
            this.label17.Text = "현재 수량";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(13, 92);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 14);
            this.label18.TabIndex = 12;
            this.label18.Text = "입고 일자";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.txtBoxspec_boxname);
            this.panel6.Controls.Add(this.txtBoxspec_height);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.txtBoxspec_length);
            this.panel6.Controls.Add(this.txtBoxspec_width);
            this.panel6.Controls.Add(this.txtBoxspec_type_name);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(279, 36);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(273, 173);
            this.panel6.TabIndex = 8;
            // 
            // txtBoxspec_boxname
            // 
            this.txtBoxspec_boxname.Location = new System.Drawing.Point(109, 140);
            this.txtBoxspec_boxname.Name = "txtBoxspec_boxname";
            this.txtBoxspec_boxname.Size = new System.Drawing.Size(145, 23);
            this.txtBoxspec_boxname.TabIndex = 21;
            // 
            // txtBoxspec_height
            // 
            this.txtBoxspec_height.Location = new System.Drawing.Point(109, 114);
            this.txtBoxspec_height.Name = "txtBoxspec_height";
            this.txtBoxspec_height.Size = new System.Drawing.Size(145, 23);
            this.txtBoxspec_height.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(13, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 14);
            this.label11.TabIndex = 18;
            this.label11.Text = "높이";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(13, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 14);
            this.label12.TabIndex = 19;
            this.label12.Text = "상자 이름";
            // 
            // txtBoxspec_length
            // 
            this.txtBoxspec_length.Location = new System.Drawing.Point(109, 88);
            this.txtBoxspec_length.Name = "txtBoxspec_length";
            this.txtBoxspec_length.Size = new System.Drawing.Size(145, 23);
            this.txtBoxspec_length.TabIndex = 17;
            // 
            // txtBoxspec_width
            // 
            this.txtBoxspec_width.Location = new System.Drawing.Point(109, 62);
            this.txtBoxspec_width.Name = "txtBoxspec_width";
            this.txtBoxspec_width.Size = new System.Drawing.Size(145, 23);
            this.txtBoxspec_width.TabIndex = 16;
            // 
            // txtBoxspec_type_name
            // 
            this.txtBoxspec_type_name.Location = new System.Drawing.Point(109, 36);
            this.txtBoxspec_type_name.Name = "txtBoxspec_type_name";
            this.txtBoxspec_type_name.Size = new System.Drawing.Size(145, 23);
            this.txtBoxspec_type_name.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "상자 정보";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(13, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 14);
            this.label6.TabIndex = 13;
            this.label6.Text = "상자 유형";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(13, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 14);
            this.label8.TabIndex = 11;
            this.label8.Text = "가로";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(13, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 14);
            this.label10.TabIndex = 12;
            this.label10.Text = "세로";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtProduct_regidate);
            this.panel5.Controls.Add(this.txtProduct_name);
            this.panel5.Controls.Add(this.txtProduct_barcode_qr);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(10, 36);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(263, 173);
            this.panel5.TabIndex = 7;
            // 
            // txtProduct_regidate
            // 
            this.txtProduct_regidate.Location = new System.Drawing.Point(102, 87);
            this.txtProduct_regidate.Name = "txtProduct_regidate";
            this.txtProduct_regidate.Size = new System.Drawing.Size(145, 23);
            this.txtProduct_regidate.TabIndex = 10;
            // 
            // txtProduct_name
            // 
            this.txtProduct_name.Location = new System.Drawing.Point(102, 61);
            this.txtProduct_name.Name = "txtProduct_name";
            this.txtProduct_name.Size = new System.Drawing.Size(145, 23);
            this.txtProduct_name.TabIndex = 9;
            // 
            // txtProduct_barcode_qr
            // 
            this.txtProduct_barcode_qr.Location = new System.Drawing.Point(102, 35);
            this.txtProduct_barcode_qr.Name = "txtProduct_barcode_qr";
            this.txtProduct_barcode_qr.Size = new System.Drawing.Size(145, 23);
            this.txtProduct_barcode_qr.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(9, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "제품 정보";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(9, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 14);
            this.label7.TabIndex = 5;
            this.label7.Text = "바코드/QR코드";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(9, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "제품명";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(9, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 14);
            this.label5.TabIndex = 3;
            this.label5.Text = "등록일자";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "기초 정보";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.panel_result);
            this.panel8.Controls.Add(this.label13);
            this.panel8.Location = new System.Drawing.Point(474, 229);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(406, 127);
            this.panel8.TabIndex = 9;
            // 
            // panel_result
            // 
            this.panel_result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_result.Controls.Add(this.lbl_result_print);
            this.panel_result.Location = new System.Drawing.Point(12, 35);
            this.panel_result.Name = "panel_result";
            this.panel_result.Size = new System.Drawing.Size(379, 79);
            this.panel_result.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(14, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 15);
            this.label13.TabIndex = 4;
            this.label13.Text = "출력 창";
            // 
            // lbl_result_print
            // 
            this.lbl_result_print.AutoSize = true;
            this.lbl_result_print.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_result_print.Location = new System.Drawing.Point(151, 29);
            this.lbl_result_print.Name = "lbl_result_print";
            this.lbl_result_print.Size = new System.Drawing.Size(39, 19);
            this.lbl_result_print.TabIndex = 0;
            this.lbl_result_print.Text = "출력";
            // 
            // BarcodeQRRecognizeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 634);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPrev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BarcodeQRRecognizeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "물류:::바코드 및 QR 인식";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BarcodeTest_FormClosing);
            this.Load += new System.EventHandler(this.BarcodeTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel_result.ResumeLayout(false);
            this.panel_result.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtBarcode;
        private Button btnPrev;
        private Label lblDialog;
        private Panel panel1;
        private Label lblTitle;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private Label label2;
        private Label label5;
        private Label label3;
        private Label label7;
        private Panel panel5;
        private Panel panel6;
        private Label label9;
        private TextBox txtProduct_regidate;
        private TextBox txtProduct_name;
        private TextBox txtProduct_barcode_qr;
        private TextBox txtBoxspec_length;
        private TextBox txtBoxspec_width;
        private TextBox txtBoxspec_type_name;
        private Label label4;
        private Label label6;
        private Label label8;
        private Label label10;
        private TextBox txtBoxspec_boxname;
        private TextBox txtBoxspec_height;
        private Label label11;
        private Label label12;
        private Panel panel7;
        private TextBox txtWarehouse_regidate;
        private TextBox txtWarehouse_current_cnt;
        private TextBox txtWarehouse_barcode_qr;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Panel panel8;
        private Label label13;
        private Panel panel_result;
        private Label lbl_result_print;
    }
}