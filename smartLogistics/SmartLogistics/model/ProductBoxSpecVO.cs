using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLogistics.model
{
    internal class ProductBoxSpecVO
    {
        private int _product_id;
        private int _box_type_id;
        private string _type_name;
        private int _width;
        private int _length;
        private int _height;
        private string _box_name;
        private string _regidate;
        private string _ip;

        public int product_id
        {
            get { return _product_id; }
            set { _product_id = value; }
        }

        public int box_type_id
        {
            get { return _box_type_id; }
            set { _box_type_id = value; }
        }

        public string type_name
        {
            get { return _type_name; }
            set { _type_name = value; }
        }

        public int width
        {
            get { return _width; }
            set { _width = value; }
        }

        public int length
        {
            get { return _length; }
            set { _length = value; }
        }

        public int height
        {
            get { return _height; }
            set { _height = value; }
        }

        public string box_name
        {
            get { return _box_name; }
            set { _box_name = value; }
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
