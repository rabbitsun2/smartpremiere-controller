using SmartLogistics.model;
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
    public partial class ProductImgMgtFrm : Form
    {

        IProjectService projectService = new ProjectService();
        IProductService productService = new ProductService();

        public ProductImgMgtFrm()
        {
            InitializeComponent();
        }

        private void ProductMgtFrm_Load(object sender, EventArgs e)
        {
            loadDbData();
            toolStripStatusLbl.Text = "정상 작동";
        }

        private void loadDbData()
        {
            DataSet ds;
            ds = productService.SelectProductImgUuid();
            string tmp = "";
            int cnt = 0;

            cmbProductName.Items.Clear();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                tmp = dr["project_id"].ToString() + "-" + dr["product_id"].ToString();
                tmp = tmp + "/" + dr["product_name"].ToString();

                cmbProductName.Items.Add(tmp);

                if ( cnt == 0 )
                {
                    cmbProductName.Text = tmp;
                }

                cnt++;

            }

        }

        private void ProductMgtFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Process Kill
            System.Diagnostics.Process[] mProcess = System.Diagnostics.Process.GetProcessesByName(Application.ProductName);
            foreach (System.Diagnostics.Process p in mProcess)
                p.Kill();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            DataSet ds;
            ProductImgUuidVO productImgUuidVO = new ProductImgUuidVO();
            string tmp = "";
            string parser = "";
            int product_id = -1;

            if ( cmbProductName.Text.Length != 0)
            {
                tmp = cmbProductName.Text;
                tmp = tmp.Substring(0, tmp.IndexOf("-") + 1);
                tmp = cmbProductName.Text.Replace(tmp, "");
                tmp = tmp.Substring(0, tmp.IndexOf("/"));

                //MessageBox.Show(tmp);
                product_id = int.Parse(tmp);
                productImgUuidVO.product_id = product_id;

                ds = productService.SelectProductImgFindID(productImgUuidVO);
                dgvList.DataSource = ds.Tables[0];

                SizeAllColumns();

            }

        }

        private void SizeAllColumns()
        {
            dgvList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            ProductMainFrm frm = new ProductMainFrm();
            frm.Show();
            this.Hide();
        }

        private void btnImgDelete_Click(object sender, EventArgs e)
        {

            DataSet ds;
            int product_id = -1;
            string myPath = setting.SMConfig.GetSmartLogisticsDir();
            string myTrain = myPath + "/train";
            string realFullPath = "";
            string realFullFile = "";
            string strProject_id = lblProject_id_val.Text;
            string tmp = "";

            if ( strProject_id.IndexOf("[") != -1 &&
                strProject_id.IndexOf("]") != -1 )
            {
                MessageBox.Show("데이터를 선택 후 사용하세요.", "확인", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            tmp = "프로젝트ID:" + lblProject_id_val.Text + " / ";
            tmp = tmp + "제품:" + lblProduct_id_val.Text + "번 \n";
            tmp = tmp + "UUID:" + lblUuid_val.Text + "\n";
            tmp = tmp + "파일명:" + lblFilename_val.Text + "을 삭제하시겠습니까?";

            if (MessageBox.Show(tmp, "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                // 데이터가 없는 경우 return
                if (this.dgvList.RowCount == 0)
                    return;

                // 현재 Row를 가져온다.
                DataGridViewRow dgvr = dgvList.CurrentRow;

                if (dgvr != null)
                {
                    // 선택한 Row의 데이터를 가져온다.
                    DataRow row = (dgvr.DataBoundItem as DataRowView).Row;

                    ProductImgUuidVO productImgUuidVO = new ProductImgUuidVO();
                    productImgUuidVO.uuid = row["uuid"].ToString();
                    productImgUuidVO.option = row["file_name"].ToString();

                    realFullPath = myTrain + "/" + row["uuid"].ToString();
                    realFullFile = realFullPath + "/" + row["file_name"].ToString();

                    // 파일 삭제
                    if (File.Exists(realFullFile) == true)
                    {
                        //MessageBox.Show("파일 삭제 완료", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        File.Delete(realFullFile);
                    }

                    // 폴더 삭제
                    if (System.IO.Directory.Exists(realFullPath) == false)
                    {
                        //MessageBox.Show("폴더 삭제 완료", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        System.IO.Directory.Delete(realFullPath);
                    }

                    // DB 삭제
                    productService.DeleteProductImgUuid(productImgUuidVO);
                    MessageBox.Show("삭제가 성공적으로 완료되었습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 새로고침
                    product_id = int.Parse(row["제품ID"].ToString());
                    productImgUuidVO.product_id = product_id;

                    ds = productService.SelectProductImgFindID(productImgUuidVO);
                    dgvList.DataSource = ds.Tables[0];

                    SizeAllColumns();


                }
                else
                {
                    MessageBox.Show("데이터가 존재하지 않습니다.", "확인", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }

            }

        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // 데이터가 없는 경우 return
            if (this.dgvList.RowCount == 0)
                return;

            // 현재 Row를 가져온다.
            DataGridViewRow dgvr = dgvList.CurrentRow;

            if (dgvr != null)
            {

                // 선택한 Row의 데이터를 가져온다.
                DataRow row = (dgvr.DataBoundItem as DataRowView).Row;

                // TextBox에 그리드 데이터를 넣는다.
                lblProject_id_val.Text = row["프로젝트ID"].ToString();
                lblProduct_id_val.Text = row["제품ID"].ToString();
                lblUuid_val.Text = row["uuid"].ToString();
                lblFilename_val.Text = row["file_name"].ToString();

            }
            else
            {
                MessageBox.Show("데이터가 존재하지 않습니다.", "확인", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }

        }

        private void btnCameraCapture_Click(object sender, EventArgs e)
        {
            string tmp = cmbProductName.Text;
            string strProject_id = "";
            string strProduct_id = "";
            string sendData = "";

            if (cmbProductName.Text.Length != 0)
            {
                tmp = cmbProductName.Text;
                tmp = tmp.Substring(0, tmp.IndexOf("-"));
                strProject_id = tmp;

                tmp = cmbProductName.Text;
                tmp = tmp.Substring(0, tmp.IndexOf("-") + 1);
                tmp = cmbProductName.Text.Replace(tmp, "");
                tmp = tmp.Substring(0, tmp.IndexOf("/"));
                strProduct_id = tmp;

                sendData = strProject_id + "-" + strProduct_id + "/";

                AddProductCameraCaptureFrm frm = new AddProductCameraCaptureFrm(sendData);
                frm.Show();
                this.Hide();

                //MessageBox.Show(strProject_id + "/" + strProduct_id);

            }

        }

        private void btnDetailView_Click(object sender, EventArgs e)
        {
            string sendData = "";
            string strProject_id = lblProject_id_val.Text;
            sendData = lblUuid_val.Text + "," + lblFilename_val.Text + "/";


            if (strProject_id.IndexOf("[") != -1 &&
                strProject_id.IndexOf("]") != -1)
            {
                MessageBox.Show("데이터를 선택 후 사용하세요.", "확인",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                ImgDetailViewFrm frm = new ImgDetailViewFrm(sendData);
                frm.ShowDialog();
            }

        }

    }

}
