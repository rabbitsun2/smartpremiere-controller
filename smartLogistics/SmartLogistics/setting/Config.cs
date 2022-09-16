/*
 * Created Date: 2022-07-19 (Tue)
 * Author: Doyun Jung (정도윤) / rabbit.white@daum.net
 * Subject: Config
 * Filename: Config.cs
 * Description:
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLogistics.setting
{
    internal class SMConfig
    {
        public const int ROOT_DIR = 0;
        public const int DB_HOST = 1;
        public const int DB_NAME = 2;
        public const int DB_USER = 3;
        public const int DB_PASSWORD = 4;
        public const int DB_PORT = 5;
        public const int PYTHON_ROOT_DIR = 6;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="choose"></param>
        /// <returns></returns>
        public string GetMyConfig(int choose)
        {
            string filename = System.IO.Directory.GetCurrentDirectory();
            filename += "\\config.ini";

            string tmp = "";

            int index = 0;

            using (StreamReader sr = new StreamReader(filename))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    if(index == choose)
                    {
                        tmp = line;
                        break;
                    }

                    index++;
                }

            }

            return tmp;
        }

        public static string GetSmartLogisticsDir()
        {
            SMConfig config = new SMConfig();
            return config.GetMyConfig(ROOT_DIR);
        }

    }
}
