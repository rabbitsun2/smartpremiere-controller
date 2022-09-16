/*
 * Created Date: 2022-07-19 (Tue)
 * Author: Doyun Jung (정도윤) / rabbit.white@daum.net
 * Subject: ProductVO
 * Filename: ProductVO.cs
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
    internal class ProductVO
    {
        private int _product_id;
        private string _product_name;
        private string _description;
        private string _regidate;
        private string _ip;
        private int _project_id;


        public int product_id
        {
            get{ return _product_id; }
            set{ _product_id = value; }
        }

        public string product_name
        {
            get { return _product_name; }    
            set { _product_name = value; }
        }

        public string description
        {
            get { return _description; } 
            set { _description = value; }
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

        public int project_id
        {
            get { return _project_id; }
            set { _project_id = value; }
        }

    }
}
