using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLogistics.model
{
    internal class ProductImgUuidVO
    {
        private int _project_id;
        private string _project_name;
        private int _product_id;
        private string _product_name;
        private string _description;
        private string _uuid;
        private string _regidate;
        private string _ip;
        private string _option;

        public int project_id
        {
            get { return _project_id; }
            set { _project_id = value; }
        }

        public string project_name
        {
            get { return _project_name; }
            set { _project_name = value; }
        }

        public int product_id
        {
            get { return _product_id; }
            set { _product_id = value; }
        }

        public string product_name
        {
            get { return _product_name; }
            set { _product_name = value; }
        }

        public string description {
            get { return _description; }
            set { _description = value; }
        }

        public string uuid
        {
            get { return _uuid; }
            set { _uuid = value; }
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

        public string option
        {
            get { return _option; }
            set { _option = value; }
        }

    }
}
