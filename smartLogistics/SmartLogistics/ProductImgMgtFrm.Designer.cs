namespace SmartLogistics
{
    partial class ProductImgMgtFrm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDetailView = new System.Windows.Forms.Button();
            this.btnImgDelete = new System.Windows.Forms.Button();
            this.lblDgvTitle = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCameraCapture = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbProductName = new System.Windows.Forms.ComboBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblFilename_val = new System.Windows.Forms.Label();
            this.lblFilename = new System.Windows.Forms.Label();
            this.lblUuid_val = new System.Windows.Forms.Label();
            this.lblUuid = new System.Windows.Forms.Label();
            this.lblProduct_id_val = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblProject_id_val = new System.Windows.Forms.Label();
            this.lblProjectId = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(20, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(166, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "제품 - 학습 데이터 관리";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDetailView);
            this.panel1.Controls.Add(this.btnImgDelete);
            this.panel1.Controls.Add(this.lblDgvTitle);
            this.panel1.Controls.Add(this.dgvList);
            this.panel1.Location = new System.Drawing.Point(12, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 269);
            this.panel1.TabIndex = 1;
            // 
            // btnDetailView
            // 
            this.btnDetailView.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDetailView.Location = new System.Drawing.Point(838, 15);
            this.btnDetailView.Name = "btnDetailView";
            this.btnDetailView.Size = new System.Drawing.Size(77, 28);
            this.btnDetailView.TabIndex = 3;
            this.btnDetailView.Text = "상세보기";
            this.btnDetailView.UseVisualStyleBackColor = true;
            this.btnDetailView.Click += new System.EventHandler(this.btnDetailView_Click);
            // 
            // btnImgDelete
            // 
            this.btnImgDelete.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnImgDelete.Location = new System.Drawing.Point(925, 15);
            this.btnImgDelete.Name = "btnImgDelete";
            this.btnImgDelete.Size = new System.Drawing.Size(75, 28);
            this.btnImgDelete.TabIndex = 2;
            this.btnImgDelete.Text = "삭제";
            this.btnImgDelete.UseVisualStyleBackColor = true;
            this.btnImgDelete.Click += new System.EventHandler(this.btnImgDelete_Click);
            // 
            // lblDgvTitle
            // 
            this.lblDgvTitle.AutoSize = true;
            this.lblDgvTitle.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDgvTitle.Location = new System.Drawing.Point(15, 17);
            this.lblDgvTitle.Name = "lblDgvTitle";
            this.lblDgvTitle.Size = new System.Drawing.Size(99, 15);
            this.lblDgvTitle.TabIndex = 1;
            this.lblDgvTitle.Text = "학습 데이터 결과";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(15, 53);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowTemplate.Height = 25;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(985, 201);
            this.dgvList.TabIndex = 0;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCameraCapture);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.cmbProductName);
            this.panel2.Controls.Add(this.lblProductName);
            this.panel2.Location = new System.Drawing.Point(12, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1015, 60);
            this.panel2.TabIndex = 2;
            // 
            // btnCameraCapture
            // 
            this.btnCameraCapture.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCameraCapture.Location = new System.Drawing.Point(370, 15);
            this.btnCameraCapture.Name = "btnCameraCapture";
            this.btnCameraCapture.Size = new System.Drawing.Size(97, 26);
            this.btnCameraCapture.TabIndex = 3;
            this.btnCameraCapture.Text = "추가 촬영";
            this.btnCameraCapture.UseVisualStyleBackColor = true;
            this.btnCameraCapture.Click += new System.EventHandler(this.btnCameraCapture_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(289, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 26);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbProductName
            // 
            this.cmbProductName.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbProductName.FormattingEnabled = true;
            this.cmbProductName.Location = new System.Drawing.Point(82, 16);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(199, 23);
            this.cmbProductName.TabIndex = 3;
            this.cmbProductName.UseWaitCursor = true;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProductName.Location = new System.Drawing.Point(15, 18);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(50, 17);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "제품명";
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrev.Location = new System.Drawing.Point(940, 16);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(87, 26);
            this.btnPrev.TabIndex = 3;
            this.btnPrev.Text = "이전";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblFilename_val);
            this.panel3.Controls.Add(this.lblFilename);
            this.panel3.Controls.Add(this.lblUuid_val);
            this.panel3.Controls.Add(this.lblUuid);
            this.panel3.Controls.Add(this.lblProduct_id_val);
            this.panel3.Controls.Add(this.lblProductId);
            this.panel3.Controls.Add(this.lblProject_id_val);
            this.panel3.Controls.Add(this.lblProjectId);
            this.panel3.Location = new System.Drawing.Point(12, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1015, 51);
            this.panel3.TabIndex = 4;
            // 
            // lblFilename_val
            // 
            this.lblFilename_val.AutoSize = true;
            this.lblFilename_val.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFilename_val.Location = new System.Drawing.Point(773, 17);
            this.lblFilename_val.Name = "lblFilename_val";
            this.lblFilename_val.Size = new System.Drawing.Size(17, 15);
            this.lblFilename_val.TabIndex = 8;
            this.lblFilename_val.Text = "[]";
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFilename.Location = new System.Drawing.Point(670, 17);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(50, 17);
            this.lblFilename.TabIndex = 7;
            this.lblFilename.Text = "파일명";
            // 
            // lblUuid_val
            // 
            this.lblUuid_val.AutoSize = true;
            this.lblUuid_val.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUuid_val.Location = new System.Drawing.Point(379, 18);
            this.lblUuid_val.Name = "lblUuid_val";
            this.lblUuid_val.Size = new System.Drawing.Size(17, 15);
            this.lblUuid_val.TabIndex = 6;
            this.lblUuid_val.Text = "[]";
            // 
            // lblUuid
            // 
            this.lblUuid.AutoSize = true;
            this.lblUuid.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUuid.Location = new System.Drawing.Point(324, 16);
            this.lblUuid.Name = "lblUuid";
            this.lblUuid.Size = new System.Drawing.Size(41, 17);
            this.lblUuid.TabIndex = 5;
            this.lblUuid.Text = "Uuid";
            // 
            // lblProduct_id_val
            // 
            this.lblProduct_id_val.AutoSize = true;
            this.lblProduct_id_val.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProduct_id_val.Location = new System.Drawing.Point(268, 19);
            this.lblProduct_id_val.Name = "lblProduct_id_val";
            this.lblProduct_id_val.Size = new System.Drawing.Size(17, 15);
            this.lblProduct_id_val.TabIndex = 4;
            this.lblProduct_id_val.Text = "[]";
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProductId.Location = new System.Drawing.Point(174, 16);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(55, 17);
            this.lblProductId.TabIndex = 3;
            this.lblProductId.Text = "제품 ID";
            // 
            // lblProject_id_val
            // 
            this.lblProject_id_val.AutoSize = true;
            this.lblProject_id_val.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProject_id_val.Location = new System.Drawing.Point(125, 19);
            this.lblProject_id_val.Name = "lblProject_id_val";
            this.lblProject_id_val.Size = new System.Drawing.Size(17, 15);
            this.lblProject_id_val.TabIndex = 2;
            this.lblProject_id_val.Text = "[]";
            // 
            // lblProjectId
            // 
            this.lblProjectId.AutoSize = true;
            this.lblProjectId.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProjectId.Location = new System.Drawing.Point(15, 16);
            this.lblProjectId.Name = "lblProjectId";
            this.lblProjectId.Size = new System.Drawing.Size(83, 17);
            this.lblProjectId.TabIndex = 1;
            this.lblProjectId.Text = "프로젝트 ID";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 469);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1039, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLbl
            // 
            this.toolStripStatusLbl.Name = "toolStripStatusLbl";
            this.toolStripStatusLbl.Size = new System.Drawing.Size(121, 17);
            this.toolStripStatusLbl.Text = "toolStripStatusLabel1";
            // 
            // ProductImgMgtFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 491);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductImgMgtFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "제품:::학습 데이터 관리";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductMgtFrm_FormClosing);
            this.Load += new System.EventHandler(this.ProductMgtFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Panel panel1;
        private Panel panel2;
        private Label lblProductName;
        private ComboBox cmbProductName;
        private Button btnSearch;
        private DataGridView dgvList;
        private Button btnPrev;
        private Label lblDgvTitle;
        private Button btnImgDelete;
        private Panel panel3;
        private Label lblProjectId;
        private Label lblProject_id_val;
        private Label lblProduct_id_val;
        private Label lblProductId;
        private Label lblUuid_val;
        private Label lblUuid;
        private Label lblFilename_val;
        private Label lblFilename;
        private Button btnCameraCapture;
        private Button btnDetailView;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLbl;
    }
}