using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HuoDai.ClassInfos
{
    class goods
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
        private int g_ID;
        public int intg_ID
        {
            get { return g_ID; }
            set { g_ID = value; }
        }
        private float g_weight;
        public float flg_weight
        {
            get { return g_weight; }
            set { g_weight = value; }
        }
        private double price;
        public double doprice
        {
            get { return price; }
            set { price = value; }
        }
        private int Flag;  //是否发布
        public int intFlag
        {
            get { return Flag; }
            set { Flag = value; }
        }
    }
}
