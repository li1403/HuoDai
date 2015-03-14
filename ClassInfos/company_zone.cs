using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HuoDai.ClassInfos
{
    class company_zone
    {
        private string c_name;
        public string strc_name
        {
            get { return c_name; }
            set { c_name = value; }
        }
        private int z_ID;
        public int intz_ID
        {
            get { return z_ID; }
            set { z_ID = value; }
        }
        private int Flag;  //是否发布
        public int intFlag
        {
            get { return Flag; }
            set { Flag = value; }
        }
    }
}
