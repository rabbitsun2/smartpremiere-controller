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
    public partial class ProductRegisterSuccessFrm : Form
    {
        public ProductRegisterSuccessFrm(String recvData)
        {

            InitializeComponent();

            // 데이터 값 가져오기
            string tmp = recvData.Substring(0, recvData.IndexOf("/"));
            lblTxtProjectId.Text = tmp;
            recvData = recvData.Replace(tmp + "/", "");
            tmp = recvData.Substring(0, recvData.IndexOf("/"));
            lblTxtProjectName.Text = tmp;
            recvData = recvData.Replace(tmp + "/", "");
            tmp = recvData.Substring(0, recvData.IndexOf("/"));
            lblTxtProductName.Text = tmp;
            recvData = recvData.Replace(tmp + "/", "");
            tmp = recvData.Substring(0, recvData.IndexOf("/"));
            lblTxtDescription.Text = tmp;

            // 키 단축키
            KeyPreview = true;

        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            nextProcess();
        }

        private void nextProcess() { 
        
            ProductMainFrm frm = new ProductMainFrm();
            frm.Show();
            this.Hide();
        }

        private void ProductRegisterSuccessFrm_FormClosing(object sender, FormClosingEventArgs e)
        {

            // Process Kill
            System.Diagnostics.Process[] mProcess = System.Diagnostics.Process.GetProcessesByName(Application.ProductName);
            foreach (System.Diagnostics.Process p in mProcess)
                p.Kill();
        }

        private void ProductRegisterSuccessFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.O)
            {
                nextProcess();
            }

        }

    }

}
