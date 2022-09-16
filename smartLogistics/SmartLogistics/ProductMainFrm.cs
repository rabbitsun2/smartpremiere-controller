/*
 * Created Date: 2022-06-28 (Tue)
 * Author: Doyun Jung (정도윤) / rabbit.white@daum.net
 * Subject: ProductMainFrm
 * Filename: ProductMainFrm.cs
 * Description:
 * - 1. 이전 이동 기능 추가, 정도윤, 2022-08-10 (Wed)
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
    public partial class ProductMainFrm : Form
    {
        public ProductMainFrm()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void ProductMainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Process Kill
            System.Diagnostics.Process[] mProcess = System.Diagnostics.Process.GetProcessesByName(Application.ProductName);
            foreach (System.Diagnostics.Process p in mProcess)
                p.Kill();
        }


        private void btn_menu_1_Click(object sender, EventArgs e)
        {
            ProjectListFrm frm = new ProjectListFrm();
            frm.Show();
            this.Hide();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            prevProcess();
        }

        private void btn_menu_2_Click(object sender, EventArgs e)
        {
            ProductImgMgtFrm frm = new ProductImgMgtFrm();
            frm.Show();
            this.Hide();
        }

        private void ProductMainFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.P)
            {
                prevProcess();
            }

        }

        private void prevProcess() {

            MainFrm frm = new MainFrm();
            frm.Show();
            this.Hide();

        }

    }
}
