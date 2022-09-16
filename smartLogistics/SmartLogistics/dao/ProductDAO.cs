/*
 * Created Date: 2022-07-19 (Tue)
 * Author: Doyun Jung (정도윤) / rabbit.white@daum.net
 * Subject: ProductDAO
 * Filename: ProductDAO.cs
 * Description:
 * 1. 바코드 기능으로 변경, 정도윤, 2022-08-14.
 */
using MySql.Data.MySqlClient;
using SmartLogistics.conn;
using SmartLogistics.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLogistics.dao
{
    internal class ProductDAO : IProductDAO
    {

		private const string INSERT_PRODUCT_QUERY = "INSERT INTO smart_product (product_name, description, " +
										"regidate, ip, project_id) VALUES (@product_name, @description, " +
										"@regidate, @ip, @project_id)";

		private const string INSERT_PRODUCT_IMG_DICTIONARY_QRY = "INSERT INTO smart_product_img_dictionary (product_id, type, " +
										"uuid, train_dir, file_name, regidate, ip) VALUES (@product_id, @type, " +
										"@uuid, @train_dir, @file_name, @regidate, @ip)";

		private const string SELECT_PRODUCT_ONE_QUERY = "select * from smart_product " +
													" where product_name = @product_name" +
													" AND description = @description " +
													" AND regidate = @regidate " +
													" AND ip = @ip " +
													" AND project_id = @project_id";

		private const string INSERT_PRODUCT_BARCODE_QRY = "INSERT INTO smart_product_barcode (product_id, " +
											"rand_id, regidate, ip) VALUES(@product_id, @rand_id, @regidate, @ip)";

		private const string SELECT_PRODUCT_BARCODE_FIND_ID_QRY = "SELECT * FROM smart_product_barcode " +
											"WHERE product_id = @product_id";

		private const string SELECT_PRODUCT_BARCODE_FIND_RAND_ID_QRY = "SELECT * FROM smart_product_barcode " +
											"WHERE rand_id = @rand_id";

		private const string SELECT_PRODUCT_IMG_DICT_QRY = "SELECT distinct(smart_project.project_id) AS 'project_id', " +
															"smart_project.project_name, smart_product.product_id, " +
															"smart_product.product_name, smart_product.description, " +
															"smart_product_img_dictionary.`uuid`, " +
															"smart_product.regidate AS 'regidate', smart_product.ip AS 'ip' " +
															"FROM smart_project, smart_product, smart_product_img_dictionary " +
															"WHERE smart_product.project_id = smart_project.project_id " +
															"AND smart_product.product_id = smart_product_img_dictionary.product_id " +
															"ORDER BY smart_product.product_id";

		private const string SELECT_PRODUCT_IMG_DICT_FIND_PRODUCT_ID_QRY = "SELECT smart_project.project_id AS '프로젝트ID', " +
															"smart_project.project_name AS '프로젝트명', smart_product.product_id AS '제품ID', " +
															"smart_product.product_name AS '제품명', smart_product.description AS '설명', " +
															"smart_product_img_dictionary.uuid, " +
															"smart_product_img_dictionary.type, smart_product_img_dictionary.train_dir, " +
															"smart_product_img_dictionary.type, smart_product_img_dictionary.file_name, " +
															"smart_product.regidate AS '등록일자', smart_product.ip AS 'IP' " +
															"FROM smart_project, smart_product, smart_product_img_dictionary " +
															"WHERE smart_product.project_id = smart_project.project_id " +
															"AND smart_product.product_id = smart_product_img_dictionary.product_id " + 
															"AND smart_product.product_id = @product_id " +
															"ORDER BY smart_product.product_id";

		private const string DELETE_PRODUCT_UUID_IMG_DIR_QRY = "DELETE FROM smart_product_img_dictionary WHERE uuid = @uuid " +
																"AND file_name = @file_name";

		private const string SELECT_DISTINCT_PRODUCT_IMG_DICT_FIND_PRODUCT_ID = "SELECT DISTINCT(smart_product_img_dictionary.product_id), " +
																			"smart_product_img_dictionary.type, smart_product_img_dictionary.uuid, " +
																			"smart_product_img_dictionary.train_dir, " +
																			"smart_product_img_dictionary.regidate, " +
																			"smart_product_img_dictionary.ip FROM smart_product_img_dictionary " +
																			"WHERE smart_product_img_dictionary.product_id = @product_id";

		private const string SELECT_COUNT_PROUDCT_IMG_DICT_FIND_PRODUCT_ID = "SELECT count(product_id) as 'cnt' FROM smart_product_img_dictionary " +
																			"WHERE smart_product_img_dictionary.product_id = @product_id";

		private const string SELECT_PRODUCT_FIND_ID_QRY = "SELECT * FROM smart_product " +
														"WHERE product_id = @product_id";

		private const string SELECT_PRODUCT_BOX_SPEC_FIND_PRODUCT_ID_QRY = "SELECT smart_product_box_spec.product_id, " + 
															"smart_product_box_spec.box_type_id, " + 
                                                            "smart_box_type.type_name, " + 
                                                            "smart_product_box_spec.width, " +
                                                            "smart_product_box_spec.`length`, " +
                                                            "smart_product_box_spec.height, " + 
                                                            "smart_product_box_spec.box_name, " + 
                                                            "smart_product_box_spec.regidate, " +
                                                            "smart_product_box_spec.ip " +
															"FROM smart_product_box_spec, smart_box_type " + 
															"WHERE smart_product_box_spec.box_type_id = smart_box_type.box_type_id " + 
															"AND smart_product_box_spec.product_id = @product_id";

		private const string INSERT_PRODUCT_BOX_SPEC_QRY = "INSERT INTO smart_product_box_spec(product_id, box_type_id, width, length, height, " +
														"box_name, regidate, ip) " +
														"VALUES(?, ?, ?, ?, ?, ?, ?, ?)";

		public int InsertProduct(ProductVO productVO)
		{
			string connectString = ConnString.getConnectionString();

			try
			{
				using (MySqlConnection mysql = new MySqlConnection(connectString))
				{
					mysql.Open();
					//accounts_table에 name, phone column 데이터를 삽입합니다. id는 자동으로 증가합니다.


					MySqlCommand cmd = new MySqlCommand(INSERT_PRODUCT_QUERY, mysql);
					cmd.Parameters.AddWithValue("@product_name", productVO.product_name);
					cmd.Parameters.AddWithValue("@description", productVO.description);
					cmd.Parameters.AddWithValue("@regidate", productVO.regidate);
					cmd.Parameters.AddWithValue("@ip", productVO.ip);
					cmd.Parameters.AddWithValue("@project_id", productVO.project_id);

					return cmd.ExecuteNonQuery();

				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}

			return -1;

		}

        public int InsertProductImgDictionary(ProductImgDictionaryVO imgDictionaryVO)
        {
			string connectString = ConnString.getConnectionString();

			try
			{
				using (MySqlConnection mysql = new MySqlConnection(connectString))
				{
					mysql.Open();
					//accounts_table에 name, phone column 데이터를 삽입합니다. id는 자동으로 증가합니다.

					MySqlCommand cmd = new MySqlCommand(INSERT_PRODUCT_IMG_DICTIONARY_QRY, mysql);

					cmd.Parameters.AddWithValue("@product_id", imgDictionaryVO.product_id);
					cmd.Parameters.AddWithValue("@type", imgDictionaryVO.type);
					cmd.Parameters.AddWithValue("@uuid", imgDictionaryVO.uuid);
					cmd.Parameters.AddWithValue("@train_dir", imgDictionaryVO.train_dir);
					cmd.Parameters.AddWithValue("@file_name", imgDictionaryVO.file_name);
					cmd.Parameters.AddWithValue("@regidate", imgDictionaryVO.regidate);
					cmd.Parameters.AddWithValue("@ip", imgDictionaryVO.ip);

					return cmd.ExecuteNonQuery();

				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}

			return -1;

		}

        public ProductVO SelectProductOne(ProductVO productVO)
		{
			string connectString = ConnString.getConnectionString();

			try
			{
				ProductVO pItem = new ProductVO();

				using (MySqlConnection mysql = new MySqlConnection(connectString))
				{
					mysql.Open();
					//accounts_table의 전체 데이터를 조회합니다.            
					

					MySqlCommand cmd = new MySqlCommand(SELECT_PRODUCT_ONE_QUERY, mysql);
					cmd.Parameters.AddWithValue("@product_name", productVO.product_name);
					cmd.Parameters.AddWithValue("@description", productVO.description);
					cmd.Parameters.AddWithValue("@regidate", productVO.regidate);
					cmd.Parameters.AddWithValue("@ip", productVO.ip);
					cmd.Parameters.AddWithValue("@project_id", productVO.project_id);

					MySqlDataReader table = cmd.ExecuteReader();


					while (table.Read())
					{
						pItem.product_id = int.Parse(table["product_id"].ToString());
						pItem.product_name = table["product_name"].ToString();
						pItem.description = table["description"].ToString();
						pItem.regidate = table["regidate"].ToString();
						pItem.ip = table["ip"].ToString();
						pItem.project_id = int.Parse(table["project_id"].ToString());

					}

					table.Close();

					return pItem;
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}

			return null;

		}

		public int InsertProductBarcode(ProductBarcodeVO productBarcodeVO)
        {

			string connectString = ConnString.getConnectionString();

			try
			{
				using (MySqlConnection mysql = new MySqlConnection(connectString))
				{
					mysql.Open();
					//accounts_table에 name, phone column 데이터를 삽입합니다. id는 자동으로 증가합니다.

					MySqlCommand cmd = new MySqlCommand(INSERT_PRODUCT_BARCODE_QRY, mysql);

					cmd.Parameters.AddWithValue("@product_id", productBarcodeVO.product_id);
					cmd.Parameters.AddWithValue("@rand_id", productBarcodeVO.rand_id);
					cmd.Parameters.AddWithValue("@regidate", productBarcodeVO.regidate);
					cmd.Parameters.AddWithValue("@ip", productBarcodeVO.ip);

					return cmd.ExecuteNonQuery();

				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}

			return -1;

		}

        public ProductBarcodeVO SelectProductBarcodeFindId(ProductBarcodeVO productBarcodeVO)
		{

			string connectString = ConnString.getConnectionString();

			try
			{
				ProductBarcodeVO pItem = null;

				using (MySqlConnection mysql = new MySqlConnection(connectString))
				{
					mysql.Open();
					//accounts_table의 전체 데이터를 조회합니다.            


					MySqlCommand cmd = new MySqlCommand(SELECT_PRODUCT_BARCODE_FIND_ID_QRY, mysql);
					cmd.Parameters.AddWithValue("@product_id", productBarcodeVO.product_id);

					MySqlDataReader table = cmd.ExecuteReader();


					while (table.Read())
					{
						if(pItem == null)
                        {
							pItem = new ProductBarcodeVO();
						}

						pItem.product_id = int.Parse(table["product_id"].ToString());
						pItem.rand_id = table["rand_id"].ToString();
						pItem.regidate = table["regidate"].ToString();
						pItem.ip = table["ip"].ToString();

					}

					table.Close();

					return pItem;
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}

			return null;

		}

        public ProductBarcodeVO SelectProductBarcodeFindRandId(ProductBarcodeVO productBarcodeVO)
		{
			string connectString = ConnString.getConnectionString();

			try
			{
				ProductBarcodeVO pItem = null;

				using (MySqlConnection mysql = new MySqlConnection(connectString))
				{
					mysql.Open();
					//accounts_table의 전체 데이터를 조회합니다.            


					MySqlCommand cmd = new MySqlCommand(SELECT_PRODUCT_BARCODE_FIND_RAND_ID_QRY, mysql);
					cmd.Parameters.AddWithValue("@rand_id", productBarcodeVO.rand_id);

					MySqlDataReader table = cmd.ExecuteReader();


					while (table.Read())
					{
						if (pItem == null)
						{
							pItem = new ProductBarcodeVO();
						}

						pItem.product_id = int.Parse(table["product_id"].ToString());
						pItem.rand_id = table["rand_id"].ToString();
						pItem.regidate = table["regidate"].ToString();
						pItem.ip = table["ip"].ToString();

					}

					table.Close();

					return pItem;
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}

			return null;

		}

        public DataSet SelectProductImgUuid()
        {

			string connectString = ConnString.getConnectionString();

			DataSet ds = new DataSet();

			using (MySqlConnection conn = new MySqlConnection(connectString))
			{
				conn.Open();
				MySqlCommand cmd = new MySqlCommand(SELECT_PRODUCT_IMG_DICT_QRY, conn);

				MySqlDataAdapter da = new MySqlDataAdapter();
				da.SelectCommand = cmd;
				da.Fill(ds);
			}

			return ds;

		}


        public DataSet SelectProductImgFindID(ProductImgUuidVO productImgUuidVO)
		{
			string connectString = ConnString.getConnectionString();

			DataSet ds = new DataSet();

			using (MySqlConnection conn = new MySqlConnection(connectString))
			{
				conn.Open();
				MySqlCommand cmd = new MySqlCommand(SELECT_PRODUCT_IMG_DICT_FIND_PRODUCT_ID_QRY, conn);
				cmd.Parameters.AddWithValue("@product_id", productImgUuidVO.product_id);

				MySqlDataAdapter da = new MySqlDataAdapter();
				da.SelectCommand = cmd;
				da.Fill(ds);
			}

			return ds;
		}

		public int DeleteProductImgUuid(ProductImgUuidVO productImgUuidVO)
        {

			string connectString = ConnString.getConnectionString();

			try
			{
				using (MySqlConnection mysql = new MySqlConnection(connectString))
				{
					mysql.Open();
					//accounts_table에 name, phone column 데이터를 삽입합니다. id는 자동으로 증가합니다.

					MySqlCommand cmd = new MySqlCommand(DELETE_PRODUCT_UUID_IMG_DIR_QRY, mysql);

					cmd.Parameters.AddWithValue("@uuid", productImgUuidVO.uuid);
					cmd.Parameters.AddWithValue("@file_name", productImgUuidVO.option);

					return cmd.ExecuteNonQuery();

				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}

			return -1;

		}

		public DataSet SelectDistinctImgDictFindProductId(ProductImgDictionaryVO productImgDictionaryVO)
		{

			string connectString = ConnString.getConnectionString();

			DataSet ds = new DataSet();

			using (MySqlConnection conn = new MySqlConnection(connectString))
			{
				conn.Open();
				MySqlCommand cmd = new MySqlCommand(SELECT_DISTINCT_PRODUCT_IMG_DICT_FIND_PRODUCT_ID, conn);
				cmd.Parameters.AddWithValue("@product_id", productImgDictionaryVO.product_id);

				MySqlDataAdapter da = new MySqlDataAdapter();
				da.SelectCommand = cmd;
				da.Fill(ds);
			}

			return ds;

		}

		public DataSet SelectCountImgDictFindProductId(ProductImgDictionaryVO productImgDictionaryVO)
        {

			string connectString = ConnString.getConnectionString();

			DataSet ds = new DataSet();

			using (MySqlConnection conn = new MySqlConnection(connectString))
			{
				conn.Open();
				MySqlCommand cmd = new MySqlCommand(SELECT_COUNT_PROUDCT_IMG_DICT_FIND_PRODUCT_ID, conn);
				cmd.Parameters.AddWithValue("@product_id", productImgDictionaryVO.product_id);

				MySqlDataAdapter da = new MySqlDataAdapter();
				da.SelectCommand = cmd;
				da.Fill(ds);
			}

			return ds;

		}

		public DataSet SelectProductFindID(ProductVO productVO)
		{

			string connectString = ConnString.getConnectionString();

			DataSet ds = new DataSet();

			using (MySqlConnection conn = new MySqlConnection(connectString))
			{
				conn.Open();
				MySqlCommand cmd = new MySqlCommand(SELECT_PRODUCT_FIND_ID_QRY, conn);
				cmd.Parameters.AddWithValue("@product_id", productVO.product_id);

				MySqlDataAdapter da = new MySqlDataAdapter();
				da.SelectCommand = cmd;
				da.Fill(ds);
			}

			return ds;

		}

		public DataSet SelectProductBoxSpecFindProductID(ProductVO productVO)
        {

			string connectString = ConnString.getConnectionString();

			DataSet ds = new DataSet();

			using (MySqlConnection conn = new MySqlConnection(connectString))
			{
				conn.Open();
				MySqlCommand cmd = new MySqlCommand(SELECT_PRODUCT_BOX_SPEC_FIND_PRODUCT_ID_QRY, conn);
				cmd.Parameters.AddWithValue("@product_id", productVO.product_id);

				MySqlDataAdapter da = new MySqlDataAdapter();
				da.SelectCommand = cmd;
				da.Fill(ds);
			}

			return ds;
		}

		public int InsertProductBoxSpec(ProductBoxSpecVO productBoxSpecVO)
        {

			string connectString = ConnString.getConnectionString();

			try
			{
				using (MySqlConnection mysql = new MySqlConnection(connectString))
				{
					mysql.Open();
					//accounts_table에 name, phone column 데이터를 삽입합니다. id는 자동으로 증가합니다.

					MySqlCommand cmd = new MySqlCommand(INSERT_PRODUCT_BOX_SPEC_QRY, mysql);

					cmd.Parameters.AddWithValue("@product_id", productBoxSpecVO.product_id);
					cmd.Parameters.AddWithValue("@box_type_id", productBoxSpecVO.box_type_id);
					cmd.Parameters.AddWithValue("@width", productBoxSpecVO.width);
					cmd.Parameters.AddWithValue("@length", productBoxSpecVO.length);
					cmd.Parameters.AddWithValue("@height", productBoxSpecVO.height);
					cmd.Parameters.AddWithValue("@box_name", productBoxSpecVO.box_name);
					cmd.Parameters.AddWithValue("@regidate", productBoxSpecVO.regidate);
					cmd.Parameters.AddWithValue("@ip", productBoxSpecVO.ip);

					return cmd.ExecuteNonQuery();

				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}

			return -1;

		}

	}

}
