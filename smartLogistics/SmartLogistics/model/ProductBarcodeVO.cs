/*
 * Created Date: 2022-08-02 (Thu)
 * Author: Doyun Jung (정도윤) / rabbit.white@daum.net
 * Subject: ProductBoxSpecVO
 * Filename: ProductBoxSpecVO.cs
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
    internal class ProductBarcodeVO
    {
        private int _product_id;
        private string _rand_id;
        private string _regidate;
        private string _ip;

        public int product_id
        {
            get { return _product_id; }
            set { _product_id = value; }
        }

        public string rand_id
        {
            get { return _rand_id; }
            set { _rand_id = value; }
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
