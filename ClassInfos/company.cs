using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HuoDai.ClassInfos
{
    class company
    {
        private string c_name;
        public string strc_name
        {
            get { return c_name; }
            set { c_name = value; }
        }
        private float weight_upper;
        public float flweight_upper
        {
            get { return weight_upper; }
            set { weight_upper = value; }
        }
        private float weight_low;
        public float flweight_low
        {
            get { return weight_low; }
            set { weight_low = value; }
        }
        private int zone_count;
        public int intzone_count
        {
            get { return zone_count; }
            set { zone_count = value; }
        }
        private int Flag;  //是否发布
        public int intFlag
        {
            get { return Flag; }
            set { Flag = value; }
        }
    }
}
