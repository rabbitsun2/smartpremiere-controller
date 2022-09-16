/*
 * Created Date: 2022-08-09 (Tue)
 * Author: Doyun Jung (정도윤) / rabbit.white@daum.net
 * Subject: ImgDetailViewFrm
 * Filename: ImgDetailViewFrm.cs
 * Description:
 * 1. 이미지 상세보기 기능 추가, 정도윤, 2022-08-09.
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
    public partial class ImgDetailViewFrm : Form
    {
        public ImgDetailViewFrm(String recvData)
        {
            InitializeComponent();

            string myPath = setting.SMConfig.GetSmartLogisticsDir();
            string myTrain = myPath + "/train";
            string realFilePath = "";
            string source_file = "";

            string tmp = recvData.Substring(0, recvData.IndexOf(","));
            string uuid = tmp;
            string file_name = "";
            tmp = recvData.Replace(tmp + ",", "");
            tmp = tmp.Substring(0, tmp.IndexOf("/"));
            file_name = tmp;

            realFilePath = myTrain + "/" + uuid;
            source_file = realFilePath + "/" + file_name;
            try
            {
                picBox.Load(@source_file);
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception e)
            {
                MessageBox.Show("예기치 못한 오류가 발생하였습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void ImgDetailViewFrm_FormClosing(object sender, FormClosingEventArgs e)
        { 
            
        }
    }
}
