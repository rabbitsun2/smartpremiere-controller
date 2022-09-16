/*
 * Created Date: 2022-07-19 (Tue)
 * Author: Doyun Jung (정도윤) / rabbit.white@daum.net
 * Subject: ConnString
 * Filename: ConnString.cs
 * Description:
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLogistics.conn
{
    internal class ConnString
    {
        public static string getConnectionString()
        {
            setting.SMConfig config = new setting.SMConfig();
            string host = config.GetMyConfig(setting.SMConfig.DB_HOST);
            string dbname = config.GetMyConfig(setting.SMConfig.DB_NAME);
            string user = config.GetMyConfig(setting.SMConfig.DB_USER);
            string pwd = config.GetMyConfig(setting.SMConfig.DB_PASSWORD);
            string port = config.GetMyConfig(setting.SMConfig.DB_PORT);

            return string.Format("Server={0};Database={1};Uid ={2};Pwd={3};Port={4};",
                                host, dbname, user, pwd, port);

        }
    }
}
