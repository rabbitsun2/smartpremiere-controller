/*
 * Created Date: 2022-07-19 (Tue)
 * Author: Doyun Jung (정도윤) / rabbit.white@daum.net
 * Subject: ProductRegisterFrm
 * Filename: ProductRegisterFrm.cs
 * Description:
 * 
 */

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
    public partial class ProductRegisterFrm : Form
    {
        public ProductRegisterFrm(string recvData)
        {
            InitializeComponent();
            KeyPreview = true;

            lblRecv.Text = recvData;

            string tmp = recvData.Substring(0, recvData.IndexOf("/"));
            txtProjectId.Text = tmp;
            tmp = recvData.Replace(tmp + "/", "");
            tmp = tmp.Substring(0, tmp.IndexOf("/"));
            txtProjectName.Text = tmp;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            nextProcess();
        }

        private void nextProcess()
        {

            string sendData = txtProjectId.Text + "/" + txtProjectName.Text + "/";
            sendData += txtProductName.Text + "," + txtDescription.Text + "/";

            if (txtProductName.TextLength < 1)
            {
                MessageBox.Show("제품명을 입력하십시오.", "확인",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtDescription.TextLength < 1)
            {
                MessageBox.Show("설명을 입력하십시오.", "확인",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ProductCameraTestFrm frm = new ProductCameraTestFrm(sendData);

            frm.Show();
            this.Hide();

        }

        private void ProductRegisterFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Process Kill
            System.Diagnostics.Process[] mProcess = System.Diagnostics.Process.GetProcessesByName(Application.ProductName);
            foreach (System.Diagnostics.Process p in mProcess)
                p.Kill();

        }

        private void ProductRegisterFrm_Load(object sender, EventArgs e)
        {

        }

        private void ProductRegisterFrm_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control && e.KeyCode == Keys.N)
            {
                nextProcess();
            }
            else if (e.Control && e.KeyCode == Keys.P)
            {
                prevProcess();
            }

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            prevProcess();

        }

        private void prevProcess()
        {
            // 폼 이동
            ProjectListFrm frm = new ProjectListFrm();
            frm.Show();
            this.Hide();
        }
    }
}
