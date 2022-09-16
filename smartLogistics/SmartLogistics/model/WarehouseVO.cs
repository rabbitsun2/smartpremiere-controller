/*
 * Created Date: 2022-09-10 (Sat) Chuseok
 * Author: Doyun Jung (정도윤) / rabbit.white@daum.net
 * Subject: WarehouseVO
 * Filename: WarehouseVO.cs
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
    internal class WarehouseVO
    {
        private int _id;
        private int _product_id;
        private int _product_cnt;
        private string _create_date;
        private string _create_type;
        private string _ip;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int product_id
        {
            get { return _product_id; }
            set { _product_id = value; }
        }

        public int product_cnt
        {
            get { return _product_cnt; }
            set { _product_cnt = value; }
        }

        public string create_date
        {
            get { return _create_date; }
            set { _create_date = value; }
        }

        public string create_type
        {
            get { return _create_type; }
            set { _create_type = value; }
        }

        public string ip
        {
            get { return _ip; }
            set { _ip = value; }
        }

    }
}
