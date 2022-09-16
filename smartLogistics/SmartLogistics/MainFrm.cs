/*
 * Created Date: 2022-06-28 (Tue)
 * Author: Doyun Jung (정도윤) / rabbit.white@daum.net
 * Subject: MainFrm
 * Filename: MainFrm.cs
 * Description:
 * 1. 코드스타일 재정의, 정도윤, 2022-07-22(Thu)
 */
using SmartLogistics.setting;
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
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void btnMenu_1_Click(object sender, EventArgs e)
        {
            ProductMainFrm frm = new ProductMainFrm();
            frm.Show();
            this.Hide();
        }

        private void btnMenu_3_Click(object sender, EventArgs e)
        {
            FaMainFrm frm = new FaMainFrm();
            frm.Show();
            this.Hide();
        }

        private void btnMenu_4_Click(object sender, EventArgs e)
        {

        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Process Kill
            System.Diagnostics.Process[] mProcess = System.Diagnostics.Process.GetProcessesByName(Application.ProductName);
            foreach (System.Diagnostics.Process p in mProcess)
                p.Kill();

        }
    }
}
