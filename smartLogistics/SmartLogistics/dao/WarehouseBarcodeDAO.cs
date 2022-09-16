/*
 * Created Date: 2022-09-10 (Sat) Chuseok
 * Author: Doyun Jung (정도윤) / rabbit.white@daum.net
 * Subject: WarehouseBarcodeDAO
 * Filename: WarehouseBarcodeDAO.cs
 * Description:
 * 
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
    internal class WarehouseBarcodeDAO : IWarehouseBarcodeDAO
    {

        private const string SELECT_WAREHOUSE_BARCODE_FIND_RAND_ID_QRY = "select * from smart_factory_warehouse_barcode " +
                                                                        "where rand_id = @rand_id";

        public DataSet SelectWarehouseBarcodeFindRandId(WarehouseBarcodeVO warehouseBarcodeVO)
        {

            string connectString = ConnString.getConnectionString();
            DataSet ds = new DataSet();

            using (MySqlConnection conn = new MySqlConnection(connectString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(SELECT_WAREHOUSE_BARCODE_FIND_RAND_ID_QRY, conn);
                cmd.Parameters.AddWithValue("@rand_id", warehouseBarcodeVO.rand_id);

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds, "tab1");
            }

            return ds;

        }

    }
}
