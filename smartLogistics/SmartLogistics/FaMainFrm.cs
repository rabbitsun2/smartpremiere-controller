/*
 * Created Date: 2022-07-21 (Thu)
 * Author: Doyun Jung (정도윤) / rabbit.white@daum.net
 * Subject: FaMainFrm
 * Filename: FaMainFrm.cs
 * Description:
 * 
 */
using SmartLogistics.setting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLogistics
{
    public partial class FaMainFrm : Form
    {
        public FaMainFrm()
        {
            InitializeComponent();
        }

        private void FaMainFrm_Load(object sender, EventArgs e)
        {

        }


        private void FaMainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Process Kill
            System.Diagnostics.Process[] mProcess = System.Diagnostics.Process.GetProcessesByName(Application.ProductName);
            foreach (System.Diagnostics.Process p in mProcess)
                p.Kill();
        }

        private void btnCreateModel_Click(object sender, EventArgs e)
        {
            AICreateModelFrm frm = new AICreateModelFrm();
            frm.Show();
            this.Hide();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            MainFrm frm = new MainFrm();
            frm.Show();
            this.Hide();
        }


        private void btnMachineMgt_Click(object sender, EventArgs e)
        {
            MachineMgtFrm frm = new MachineMgtFrm();
            frm.Show();
            this.Hide();
        }

        private void btnRobotArmController_Click(object sender, EventArgs e)
        {
            RobotArmControllerFrm frm = new RobotArmControllerFrm();
            frm.Show();
            this.Hide();
        }

        private void btnBarcodeQR_Click(object sender, EventArgs e)
        {
            BarcodeQRRecognizeFrm frm = new BarcodeQRRecognizeFrm();
            frm.Show();
            this.Hide();

        }

        private void btnFAInput_Click(object sender, EventArgs e)
        {
            FactoryAutomationInputFrm frm = new FactoryAutomationInputFrm();
            frm.Show();
            this.Hide();
        }
    }

}