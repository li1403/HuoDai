using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HuoDai.ClassInfos
{
    class zone
    {
        private int z_ID;
        public int intz_ID
        {
            get { return z_ID; }
            set { z_ID = value; }
        }
        private string z_name;
        public string strz_name
        {
            get { return z_name; }
            set { z_name = value; }
        }
        private string z_number;
        public string strz_number
        {
            get { return z_number; }
            set { z_number = value; }
        }
        private int Flag;  //是否发布
        public int intFlag
        {
            get { return Flag; }
            set { Flag = value; }
        }
    }
}
