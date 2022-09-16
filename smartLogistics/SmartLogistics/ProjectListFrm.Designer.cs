namespace SmartLogistics
{
    partial class ProjectListFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectListFrm));
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSearchBar = new System.Windows.Forms.Panel();
            this.btnData = new System.Windows.Forms.Button();
            this.TxtKeyword = new System.Windows.Forms.TextBox();
            this.panelDetailBar = new System.Windows.Forms.Panel();
            this.lblTxtProjectName = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblTxtNumber = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.panelFuncBar = new System.Windows.Forms.Panel();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelSearchBar.SuspendLayout();
            this.panelDetailBar.SuspendLayout();
            this.panelFuncBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(366, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 35);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(855, 254);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(384, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "프로젝트 선택하기";
            // 
            // panelSearchBar
            // 
            this.panelSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearchBar.Controls.Add(this.btnData);
            this.panelSearchBar.Controls.Add(this.TxtKeyword);
            this.panelSearchBar.Controls.Add(this.btnSearch);
            this.panelSearchBar.Location = new System.Drawing.Point(28, 67);
            this.panelSearchBar.Name = "panelSearchBar";
            this.panelSearchBar.Size = new System.Drawing.Size(858, 55);
            this.panelSearchBar.TabIndex = 3;
            // 
            // btnData
            // 
            this.btnData.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnData.Location = new System.Drawing.Point(447, 9);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(140, 35);
            this.btnData.TabIndex = 1;
            this.btnData.Text = "데이터 가져오기";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // TxtKeyword
            // 
            this.TxtKeyword.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtKeyword.Location = new System.Drawing.Point(22, 15);
            this.TxtKeyword.Name = "TxtKeyword";
            this.TxtKeyword.Size = new System.Drawing.Size(330, 25);
            this.TxtKeyword.TabIndex = 1;
            // 
            // panelDetailBar
            // 
            this.panelDetailBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDetailBar.Controls.Add(this.lblTxtProjectName);
            this.panelDetailBar.Controls.Add(this.lblProjectName);
            this.panelDetailBar.Controls.Add(this.lblTxtNumber);
            this.panelDetailBar.Controls.Add(this.lblNumber);
            this.panelDetailBar.Location = new System.Drawing.Point(28, 136);
            this.panelDetailBar.Name = "panelDetailBar";
            this.panelDetailBar.Size = new System.Drawing.Size(858, 35);
            this.panelDetailBar.TabIndex = 4;
            // 
            // lblTxtProjectName
            // 
            this.lblTxtProjectName.AutoSize = true;
            this.lblTxtProjectName.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTxtProjectName.Location = new System.Drawing.Point(330, 9);
            this.lblTxtProjectName.Name = "lblTxtProjectName";
            this.lblTxtProjectName.Size = new System.Drawing.Size(18, 17);
            this.lblTxtProjectName.TabIndex = 3;
            this.lblTxtProjectName.Text = "[]";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProjectName.Location = new System.Drawing.Point(148, 9);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(78, 17);
            this.lblProjectName.TabIndex = 2;
            this.lblProjectName.Text = "프로젝트명";
            // 
            // lblTxtNumber
            // 
            this.lblTxtNumber.AutoSize = true;
            this.lblTxtNumber.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTxtNumber.Location = new System.Drawing.Point(89, 9);
            this.lblTxtNumber.Name = "lblTxtNumber";
            this.lblTxtNumber.Size = new System.Drawing.Size(18, 17);
            this.lblTxtNumber.TabIndex = 1;
            this.lblTxtNumber.Text = "[]";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumber.Location = new System.Drawing.Point(15, 9);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(36, 17);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "번호";
            // 
            // panelFuncBar
            // 
            this.panelFuncBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFuncBar.Controls.Add(this.btnPrev);
            this.panelFuncBar.Controls.Add(this.btnNext);
            this.panelFuncBar.Location = new System.Drawing.Point(28, 452);
            this.panelFuncBar.Name = "panelFuncBar";
            this.panelFuncBar.Size = new System.Drawing.Size(856, 43);
            this.panelFuncBar.TabIndex = 5;
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrev.Location = new System.Drawing.Point(258, 5);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(147, 31);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "이전(P)";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(440, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(147, 31);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "다음(N)";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ProjectListFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 509);
            this.Controls.Add(this.panelFuncBar);
            this.Controls.Add(this.panelDetailBar);
            this.Controls.Add(this.panelSearchBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectListFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "제품등록 / 1단계 - 프로젝트 선택하기";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProjectListFrm_FormClosing);
            this.Load += new System.EventHandler(this.ProjectListFrm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProjectListFrm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelSearchBar.ResumeLayout(false);
            this.panelSearchBar.PerformLayout();
            this.panelDetailBar.ResumeLayout(false);
            this.panelDetailBar.PerformLayout();
            this.panelFuncBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSearch;
        private DataGridView dataGridView1;
        private Label label1;
        private Panel panelSearchBar;
        private TextBox TxtKeyword;
        private Panel panelDetailBar;
        private Button btnData;
        private Label lblNumber;
        private Label lblTxtNumber;
        private Label lblTxtProjectName;
        private Label lblProjectName;
        private Panel panelFuncBar;
        private Button btnNext;
        private Button btnPrev;
    }
}