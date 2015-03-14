using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HuoDai.DBMethods
{
    class zoneMethods
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader qlddr = null;

        #region 查询(用于单击单元格时）
        public SqlDataReader zoneMethods_Find(string strObject, int intFlag)
        {
            string strSecar = null;

            try
            {
                switch (intFlag)//判断条件
                {
                    case 1://根据渠道商名字查询
                        strSecar = "select * from zone where z_name = '" + strObject + "'";
                        break;
                    case 2://全部查询
                        strSecar = "select  * from  zone";
                        break;
                }
                getSqlConnection getConnection = new getSqlConnection();
                conn = getConnection.GetCon();
                cmd = new SqlCommand(strSecar, conn);
                qlddr = cmd.ExecuteReader();
                return qlddr;

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                return qlddr;
            }

        }
        #endregion

        #region 查询（由区域ID查区号）
        public string zoneMethods_Find2(string z_ID)
        {
            string reName = null;
            //MessageBox.Show(z_ID);
            try
            {
                int ID = int.Parse(z_ID);
                string strSecar = null;
                strSecar = "select z_number from zone where z_ID = " + ID;

                //MessageBox.Show(strSecar);
                getSqlConnection getConnection = new getSqlConnection();
                conn = getConnection.GetCon();
                cmd = new SqlCommand(strSecar, conn);
                qlddr = cmd.ExecuteReader();
                if (qlddr.Read())
                    reName = qlddr[0].ToString();
                //MessageBox.Show(reName + qlddr[0].ToString());
                qlddr.Close();
                conn.Close();
                return reName;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                return reName;
            }
        }
        #endregion

        #region 查询（由区号查区域名称）
        public string zoneMethods_Find(string z_ID)
        {
            string reName=null;
            //MessageBox.Show(z_ID);
            try
            {
                int ID = int.Parse(z_ID);
                string strSecar = null;
                strSecar = "select z_name from zone where z_ID = " + ID;

                //MessageBox.Show(strSecar);
                getSqlConnection getConnection = new getSqlConnection();
                conn = getConnection.GetCon();
                cmd = new SqlCommand(strSecar, conn);
                qlddr = cmd.ExecuteReader();
                if (qlddr.Read())
                    reName = qlddr[0].ToString();
                //MessageBox.Show(reName + qlddr[0].ToString());
                qlddr.Close();
                conn.Close();
                return reName;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                return reName;
            }
        }
        #endregion

        #region 查询（由区号查区域名称）
        public int zoneMethods_Find(string z_name, string c_name)
        {
            int z_ID=-1;
            //MessageBox.Show(z_ID);
            try
            {
                string strSecar = null;
                
                strSecar = "select zone.z_ID ";
                strSecar += "from company, zone, company_zone ";
                strSecar += "where company.c_name = company_zone.c_name and zone.z_ID = company_zone.z_ID and ";
                strSecar += "company.c_name = '" + c_name + "' and zone.z_name = '" + z_name + "'"; 

                //MessageBox.Show(strSecar);
                getSqlConnection getConnection = new getSqlConnection();
                conn = getConnection.GetCon();
                cmd = new SqlCommand(strSecar, conn);
                qlddr = cmd.ExecuteReader();
                if (qlddr.Read())
                    z_ID = int.Parse(qlddr[0].ToString());
                //MessageBox.Show(reName);
                qlddr.Close();
                return z_ID;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                return z_ID;
            }
        }
        #endregion

        #region 填充区域信息
        //使用了TreeView控件
        public void filltProd(object objTreeView, object obimage)
        {
            try
            {
                getSqlConnection getConnection = new getSqlConnection();
                conn = getConnection.GetCon();
                string strSecar = "select distinct z_name from zone";
                cmd = new SqlCommand(strSecar, conn);
                qlddr = cmd.ExecuteReader();

                if (objTreeView.GetType().ToString() == "System.Windows.Forms.TreeView")
                {
                    System.Windows.Forms.ImageList imlist = (System.Windows.Forms.ImageList)obimage;

                    System.Windows.Forms.TreeView TV = (System.Windows.Forms.TreeView)objTreeView;
                    TV.Nodes.Clear();

                    TV.ImageList = imlist;
                    System.Windows.Forms.TreeNode TN = new System.Windows.Forms.TreeNode("区域名称", 0, 1);
                    while (qlddr.Read())
                    {
                        TN.Nodes.Add("", qlddr[0].ToString(), 0, 1);

                    }
                    TV.Nodes.Add(TN);
                    qlddr.Close();
                    TV.ExpandAll();
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
