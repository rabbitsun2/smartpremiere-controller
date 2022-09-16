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
    internal class WarehouseDAO : IWarehouseDAO
    {
        private const string SELECT_WAREHOUSE_FIND_ID_QRY = "select * from smart_factory_warehouse " +
                                                            "where id = @id";

        private const string SELECT_WAREHOUSE_LOG_FIND_W_ID_QRY = "select * from smart_factory_warehouse_log " +
                                                 "where w_id = @w_id and " +
                                                 "((current_type = @current_type1 and release_type = @release_type1) or " +
                                                 "(current_type = @current_type2 and release_type = @release_type2))";

        public DataSet SelectWarehouseFindId(WarehouseVO warehouseVO)
        {

            string connectString = ConnString.getConnectionString();
            DataSet ds = new DataSet();

            using (MySqlConnection conn = new MySqlConnection(connectString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(SELECT_WAREHOUSE_FIND_ID_QRY, conn);
                cmd.Parameters.AddWithValue("@id", warehouseVO.id);

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds, "tab1");
            }

            return ds;

        }

        public DataSet SelectLatestWarehouseLogFindWid(WarehouseVO warehouseVO)
        {
            string connectString = ConnString.getConnectionString();
            DataSet ds = new DataSet();

            using (MySqlConnection conn = new MySqlConnection(connectString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(SELECT_WAREHOUSE_LOG_FIND_W_ID_QRY, conn);
                cmd.Parameters.AddWithValue("@w_id", warehouseVO.id);
                cmd.Parameters.AddWithValue("@current_type1", "신규");
                cmd.Parameters.AddWithValue("@release_type1", "해당없음");
                cmd.Parameters.AddWithValue("@current_type2", "최근");
                cmd.Parameters.AddWithValue("@release_type2", "출하");

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds, "tab1");
            }

            return ds;

        }

    }

}