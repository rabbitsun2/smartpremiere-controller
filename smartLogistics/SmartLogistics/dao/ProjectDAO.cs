/*
 * Created Date: 2022-06-28 (Tue)
 * Author: Doyun Jung (정도윤) / rabbit.white@daum.net
 * Subject: ProjectDAO
 * Filename: ProjectDAO.cs
 * Description:
 * 
 */
using MySql.Data.MySqlClient;
using SmartLogistics.conn;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLogistics.dao
{
    internal class ProjectDAO : IProjectDAO
    {
        private const string SELECT_ALL_PROJECT_QUERY = "select project_id as `번호`, " +
                         "project_name as `프로젝트명`," +
                         "description as `설명`, " +
                         "startdate as `시작일자`, " +
                         "enddate as `종료일자`, " +
                         "regidate as `등록일자`, " +
                         "ip from smart_project order by project_id";

        private const string SELECT_PROJECT_KEYWORD_QUERY = "select project_id as `번호`, " +
                                                             "project_name as `프로젝트명`," +
                                                             "description as `설명`, " +
                                                             "startdate as `시작일자`, " +
                                                             "enddate as `종료일자`, " +
                                                             "regidate as `등록일자`, " +
                                                             "ip from smart_project " +
                                                             "where project_name LIKE @keyword " +
                                                             "order by project_id";

        public DataSet SelectAllProject()
        {
            string connectString = ConnString.getConnectionString();

            DataSet ds = new DataSet();

            using (MySqlConnection conn = new MySqlConnection(connectString))
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(SELECT_ALL_PROJECT_QUERY, conn);
                da.Fill(ds);
            }

            return ds;

        }

        public DataSet SelectKeywordProject(string keyword)
        {
            string connectString = ConnString.getConnectionString();

            DataSet ds = new DataSet();

            using (MySqlConnection conn = new MySqlConnection(connectString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(SELECT_PROJECT_KEYWORD_QUERY, conn);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }

            return ds;

        }

    }

}
