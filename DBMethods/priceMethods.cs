using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HuoDai.DBMethods
{
    class priceMethods
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader qlddr = null;

        #region 查询(点击查询按钮时）
        public void priceMethods_Find(Single weight, string area, Object DataObject)
        {
            try
            {
                /*
                 * with min_weight(c_name,g_weight,g_price) as 
                    (select c_name,min(g_weight),MIN(g_price)
                     from price,zone,company_zone
                     where zone.z_ID=company_zone.z_ID and zone .z_number=price .z_number and zone .z_name ='Taiwan'
                            and g_weight>=21
                     group by c_name)
                    select min_weight.c_name,(case e_type 
                                   when 1 then g_price*e_price
                                   when 2 then g_price+e_price
                                   when 3 then g_price*(1+e_price)end) as d
      
                    from min_weight,extra_price
                    where min_weight.c_name=extra_price.c_name
                    order by d
                 * */
                string strSecar = null;
                strSecar = "with min_weight(c_name,g_weight,g_price) as (select c_name,min(g_weight),MIN(g_price) from price,zone,company_zone where zone.z_ID=company_zone.z_ID and zone .z_number=price .z_number and zone .z_name ='"+area+"' and g_weight>="+weight+" ";
                strSecar += " group by c_name) select min_weight.c_name,(case e_type when 1 then g_price*e_price when 2 then g_price+e_price when 3 then g_price*(1+e_price)end) as d ";
                //strSecar += area + "'and g_weight>=" + weight + " group by c_name) ";
                //strSecar += "select min_weight.c_name,(case e_type when 1 then g_price*e_price when 2 then g_price+e_price when 3 then g_price*(1+e_price) end) as d";
                strSecar += " from min_weight,extra_price where min_weight.c_name=extra_price.c_name order by d";

                getSqlConnection getConnection = new getSqlConnection();
                conn = getConnection.GetCon();
                cmd = new SqlCommand(strSecar, conn);
                qlddr = cmd.ExecuteReader();
                int ii = 0;
                while (qlddr.Read())
                {
                    ii++;
                }
                qlddr.Close();
                //MessageBox.Show(ii.ToString());

                System.Windows.Forms.DataGridView dv = (DataGridView)DataObject;

                if (ii != 0)
                {
                    int i = 0;
                    dv.RowCount = ii;
                    qlddr = cmd.ExecuteReader();
                    while (qlddr.Read())
                    {
                        dv[0, i].Value = qlddr[0].ToString();
                        //MessageBox.Show(qlddr[0].ToString());
                        //MessageBox.Show(qlddr[1].ToString());
                        dv[1, i].Value = qlddr[1].ToString();
                        i++;
                    }
                    qlddr.Close();
                }
                else
                {
                    if (dv.RowCount != 0)
                    {
                        int i = 0;
                        do
                        {
                            dv[0, i].Value = "";
                            dv[1, i].Value = "";
                            i++;
                        } while (i < dv.RowCount);
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        #endregion

        #region 查询2(点击查询按钮时）
        public void priceMethods_Find2(string z_number, float weight, Object DataObject)
        {
            try
            {
                string strSecar = null;
                strSecar = "select min(g_price) from price where z_number = '" + z_number + "' and g_weight >= " + weight;

                getSqlConnection getConnection = new getSqlConnection();
                conn = getConnection.GetCon();
                cmd = new SqlCommand(strSecar, conn);
                qlddr = cmd.ExecuteReader();
                int ii = 0;
                while (qlddr.Read())
                {
                    ii++;
                }
                qlddr.Close();

                System.Windows.Forms.DataGridView dv = (DataGridView)DataObject;

                if (ii != 0)
                {
                    int i = 0;
                    dv.RowCount = ii;
                    qlddr = cmd.ExecuteReader();
                    while (qlddr.Read())
                    {
                        MessageBox.Show(qlddr[0].ToString());
                        dv[0, i].Value = qlddr[0].ToString();
                        i++;
                    }
                    qlddr.Close();
                }
                else
                {
                    if (dv.RowCount != 0)
                    {
                        int i = 0;
                        do
                        {
                            dv[0, i].Value = "";
                            i++;
                        } while (i < dv.RowCount);
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        #endregion
    }
}
