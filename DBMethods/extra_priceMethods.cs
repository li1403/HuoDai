using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using HuoDai.ClassInfos;

namespace HuoDai.DBMethods
{
    class extra_priceMethods
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader qlddr = null;

        #region 添加
        public int extra_price_Add(extra_price exp) //返回0表示插入失败
        {
            int intFlag = 0;
            try
            {
                string str_Add = "insert into extra_price values( ";
                str_Add += "'" + exp.strc_name + "','" + exp.stre_name + "','" + exp.inte_type + "',";
                str_Add += "'" + exp.doe_price + "')";
                getSqlConnection getConnection = new getSqlConnection();
                conn = getConnection.GetCon();
                cmd = new SqlCommand(str_Add, conn);
                intFlag = cmd.ExecuteNonQuery();
                conn.Dispose();
                return intFlag;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                return intFlag;

            }

        }
        #endregion

        #region 修改
        public int extra_price_UpDate(extra_price exp)
        {
            int intFlag = 0;
            try
            {
                string str_Add = "update extra_price  set ";
                str_Add += "e_type='" + exp.inte_type + "',e_price='" + exp.doe_price;
                str_Add += "' where c_name ='" + exp.strc_name + "' and e_name = '" + exp.stre_name + "'";

                getSqlConnection getConnection = new getSqlConnection();
                conn = getConnection.GetCon();
                cmd = new SqlCommand(str_Add, conn);
                intFlag = cmd.ExecuteNonQuery();
                conn.Dispose();
                return intFlag;


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                return intFlag;

            }

        }
        #endregion

        #region 删除
        public int extra_price_Delete(extra_price exp)
        {
            int intFlag = 0;
            try
            {
                //string str_Add = "update tb_CompanyInfo  set ";
                //str_Add += "Flag='" + Company.intFlag + "' where CompanyID ='" + Company.intCompanyID + "'";

                string str_Delete = "delete from extra_price where c_name='" + exp.strc_name + "'";
                str_Delete += " and e_name = '" + exp.stre_name +  "'";
                getSqlConnection getConnection = new getSqlConnection();
                conn = getConnection.GetCon();
                cmd = new SqlCommand(str_Delete, conn);
                intFlag = cmd.ExecuteNonQuery();
                conn.Dispose();
                return intFlag;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                return intFlag;

            }

        }
        #endregion

        #region 查询（用于加载窗体；添加，修改和删除后显示更新的信息）
        public void extra_priceMethods_Find(string strObject, Object DataObject)
        {
            try
                {
                string strSecar = null;
                strSecar = "select * from extra_price "; //查询所有信息

                getSqlConnection getConnection = new getSqlConnection();
                conn = getConnection.GetCon();
                cmd = new SqlCommand(strSecar, conn);
                int ii = 0;
                qlddr = cmd.ExecuteReader();
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
                            dv[0, i].Value = qlddr[0].ToString();
                            dv[1, i].Value = qlddr[1].ToString();
                            switch(qlddr[2].ToString())
                            {
                                case "1": dv[2, i].Value = "折扣";
                                    break;
                                case "2": dv[2, i].Value = "每单固定价格";
                                    break;
                                case "3": dv[2, i].Value = "每单比例价格";
                                    break;
                            }
                            dv[3, i].Value = qlddr[3].ToString();
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
                            dv[2, i].Value = "";
                            dv[3, i].Value = "";
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

        #region 查询(用于单击单元格时）
        public SqlDataReader extra_priceMethods_Find(string strObject1, string strObject2, int intFlag)
        {
            string strSecar = null;

            try
            {
                switch (intFlag)//判断条件
                {
                    case 1://根据商品编号查询
                        strSecar = "select * from extra_price where c_name = '" + strObject1 + "'";
                        strSecar += "and e_name= '" + strObject2 + "'";// and Flag=0";
                        break;
                    case 2://全部查询
                        strSecar = "select  * from  extra_price";// where Flag=0";
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
    }
}
