using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLogistics.model
{
    internal class WarehouseLogVO
    {
        private int _id;
        private int _w_id;
        private int _prev_w_id;
        private int _prev_cnt;
        private int _release_cnt;
        private int _current_cnt;
        private string _current_type;
        private string _release_type;
        private string _release_date;
        private string _ip;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int w_id
        {
            get { return _w_id; }
            set { _w_id = value; }
        }

        public int prev_w_id
        {
            get { return _prev_w_id; }
            set { _prev_w_id = value; }
        }

        public int prev_cnt
        {
            get { return _prev_cnt; }
            set { _prev_cnt = value; }
        }

        public int release_cnt
        {
            get { return _release_cnt; }
            set { _release_cnt = value; }
        }

        public int current_cnt
        {
            get { return _current_cnt; }
            set { _current_cnt = value; }
        }

        public string current_type
        {
            get { return _current_type; }
            set { _current_type = value; }
        }

        public string release_type
        {
            get { return _release_type; }
            set { _release_type = value; }
        }

        public string release_date
        {
            get { return _release_date; }
            set { _release_date = value; }
        }

        public string ip
        {
            get { return _ip; }
            set { _ip = value; }
        }

    }
}
