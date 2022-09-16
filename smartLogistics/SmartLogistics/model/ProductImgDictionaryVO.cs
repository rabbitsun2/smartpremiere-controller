/*
 * Created Date: 2022-07-21 (Thu)
 * Author: Doyun Jung (정도윤) / rabbit.white@daum.net
 * Subject: ProductImgDictionaryVO
 * Filename: ProductImgDictionaryVO.cs
 * Description:
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLogistics.model
{
    internal class ProductImgDictionaryVO
    {
        private int _product_id;
        private string _type;
        private string _uuid;
        private string _train_dir;
        private string _file_name;
        private string _regidate;
        private string _ip;

        public int product_id
        {
            get { return _product_id; }
            set { _product_id = value; }
        }

        public string type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string uuid
        {
            get { return _uuid; }
            set { _uuid = value; }
        }

        public string train_dir
        {
            get { return _train_dir; }
            set { _train_dir = value; } 
        }

        public string file_name
        {
            get { return _file_name; }
            set { _file_name = value; } 
        }

        public string regidate
        {
            get { return _regidate; }
            set { _regidate = value; }
        }

        public string ip
        {
            get { return _ip; }
            set { _ip = value; }
        }

    }
}
