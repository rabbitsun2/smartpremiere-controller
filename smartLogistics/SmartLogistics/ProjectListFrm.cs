/*
 * Created Date: 2022-07-18 (Mon)
 * Author: Doyun Jung (정도윤) / rabbit.white@daum.net
 * Subject: ProjectListFrm
 * Filename: ProjectListFrm.cs
 * Description:
 * 
 */

using MySql.Data.MySqlClient;
using SmartLogistics.conn;
using SmartLogistics.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLogistics
{
    public partial class ProjectListFrm : Form
    {
        IProjectService projectService = new ProjectService();

        public ProjectListFrm()
        {
            InitializeComponent();
            loadData();
            KeyPreview = true;
        }

        private void loadData()
        {
            DataSet ds;
            ds = projectService.SelectAllProject();
            dataGridView1.DataSource = ds.Tables[0];

            SizeAllColumns();

            btnNext.Enabled = false;
        }

        private void SizeAllColumns()
        {
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }


        private void ProjectListFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Process Kill
            System.Diagnostics.Process[] mProcess = System.Diagnostics.Process.GetProcessesByName(Application.ProductName);
            foreach (System.Diagnostics.Process p in mProcess)
                p.Kill();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            DataSet ds;
            ds = projectService.SelectKeywordProject(TxtKeyword.Text);
            dataGridView1.DataSource = ds.Tables[0];

            SizeAllColumns();
        }

        private void btnData_Click(object sender, EventArgs e)
        {

            // 데이터가 없는 경우 return
            if (this.dataGridView1.RowCount == 0)
                return;

            // 현재 Row를 가져온다.
            DataGridViewRow dgvr = dataGridView1.CurrentRow;

            if (dgvr != null)
            {

                // 선택한 Row의 데이터를 가져온다.
                DataRow row = (dgvr.DataBoundItem as DataRowView).Row;

                // TextBox에 그리드 데이터를 넣는다.
                lblTxtNumber.Text = row["번호"].ToString();
                lblTxtProjectName.Text = row["프로젝트명"].ToString();

                // 다음 버튼 활성화
                btnNext.Enabled = true;
            }
            else
            {
                MessageBox.Show("데이터가 존재하지 않습니다.", "확인", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            ProductMainFrm frm = new ProductMainFrm();
            frm.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            String sendData = lblTxtNumber.Text + "/" + lblTxtProjectName.Text + "/";
            ProductRegisterFrm productRegisterFrm = new ProductRegisterFrm(sendData);
            productRegisterFrm.Show();
            this.Hide();
        }

        private void ProjectListFrm_Load(object sender, EventArgs e)
        {

        }


        private void ProjectListFrm_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control && e.KeyCode == Keys.P)
            {
                ProductMainFrm productMainFrm = new ProductMainFrm();
                productMainFrm.Show();
                this.Hide();
            }

            else if (e.Control && e.KeyCode == Keys.N)
            {
                String sendData = lblTxtNumber.Text + "/" + lblTxtProjectName.Text + "/";
                ProductRegisterFrm productRegisterFrm = new ProductRegisterFrm(sendData);
                productRegisterFrm.Show();
                this.Hide();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // 데이터가 없는 경우 return
            if (this.dataGridView1.RowCount == 0)
                return;

            // 현재 Row를 가져온다.
            DataGridViewRow dgvr = dataGridView1.CurrentRow;

            if (dgvr != null)
            {
                if (dgvr.DataBoundItem != null)
                {
                    // 선택한 Row의 데이터를 가져온다.
                    DataRow row = (dgvr.DataBoundItem as DataRowView).Row;

                    // TextBox에 그리드 데이터를 넣는다.
                    lblTxtNumber.Text = row["번호"].ToString();
                    lblTxtProjectName.Text = row["프로젝트명"].ToString();

                    // 다음 버튼 활성화
                    btnNext.Enabled = true;
                }

            }
            else
            {
                MessageBox.Show("데이터가 존재하지 않습니다.", "확인", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }
    }
}
