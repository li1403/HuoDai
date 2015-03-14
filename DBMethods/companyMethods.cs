using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HuoDai.DBMethods
{
    class companyMethods
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader qlddr = null;

        #region 查询(用于单击单元格时）
        public SqlDataReader companyMethods_Find(string strObject, int intFlag)
        {
            string strSecar = null;

            try
            {
                switch (intFlag)//判断条件
                {
                    case 1://根据渠道商名字查询
                        strSecar = "select * from company where c_name = '" + strObject + "'";
                        break;
                    case 2://全部查询
                        strSecar = "select  * from  company";
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

        #region 填充渠道商类别信息
        //使用了TreeView控件
        public void filltProd(object objTreeView, object obimage)
        {
            try
            {
                getSqlConnection getConnection = new getSqlConnection();
                conn = getConnection.GetCon();
                string strSecar = "select * from company";
                cmd = new SqlCommand(strSecar, conn);
                qlddr = cmd.ExecuteReader();

                if (objTreeView.GetType().ToString() == "System.Windows.Forms.TreeView")
                {
                    System.Windows.Forms.ImageList imlist = (System.Windows.Forms.ImageList)obimage;

                    System.Windows.Forms.TreeView TV = (System.Windows.Forms.TreeView)objTreeView;
                    TV.Nodes.Clear();

                    TV.ImageList = imlist;
                    System.Windows.Forms.TreeNode TN = new System.Windows.Forms.TreeNode("渠道商名称", 0, 1);
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
