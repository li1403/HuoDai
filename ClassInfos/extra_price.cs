using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HuoDai.ClassInfos
{
    class extra_price
    {
        private string c_name;
        public string strc_name
        {
            get { return c_name; }
            set { c_name = value; }
        }
        private string e_name;
        public string stre_name
        {
            get { return e_name; }
            set { e_name = value; }
        }
        private int e_type;
        public int inte_type
        {
            get { return e_type; }
            set { e_type = value; }
        }
        private double e_price;
        public double doe_price
        {
            get { return e_price; }
            set { e_price = value; }
        }
        private int Flag;  //是否发布
        public int intFlag
        {
            get { return Flag; }
            set { Flag = value; }
        }
    }
}
