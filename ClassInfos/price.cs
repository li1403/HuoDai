using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HuoDai.ClassInfos
{
    class price
    {
        private string z_number;
        public string strz_number
        {
            get { return z_number; }
            set { z_number = value; }
        }
        private float g_weight;
        public float flg_weight
        {
            get { return g_weight; }
            set { g_weight = value; }
        }
        private double g_price;
        public double dog_price
        {
            get { return g_price; }
            set { g_price = value; }
        }
        private int Flag;  //是否发布
        public int intFlag
        {
            get { return Flag; }
            set { Flag = value; }
        }
    }
}
