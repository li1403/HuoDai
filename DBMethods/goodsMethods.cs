using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using HuoDai.ClassInfos;

namespace HuoDai.DBMethods
{
    class goodsMethods
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader qlddr = null;

        zoneMethods zMethod = new zoneMethods();
        priceMethods priceMethod = new priceMethods();

        #region 添加
        public int goods_Add(goods good) //返回0表示插入失败
        {
            int intFlag = 0;
            try
            {
                string str_Add = "insert into goods values(";
                str_Add += "'" + good.strc_name + "','" + good.intz_ID + "',";
                str_Add += "'" + good.flg_weight + "','" + good.doprice + "')";
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

        #region 添加2
        public int goods_zhekou_Add(goods good) //返回0表示插入失败
        {
            int intFlag = 0;
            try
            {
                string z_name = zMethod.zoneMethods_Find(good.intz_ID.ToString());
                string z_number = zMethod.zoneMethods_Find2(good.intz_ID.ToString());
                DataGridView dv = new DataGridView();
                dv.ColumnCount = 3;
                priceMethod.priceMethods_Find(good.flg_weight, z_name, dv);
                string my_c_name;
                double my_price;
                my_c_name = dv[0, 0].Value.ToString();
                my_price = Convert.ToDouble(dv[1, 0].Value.ToString());
                double yuanjia,zhekou;
                priceMethod.priceMethods_Find2(z_number, good.flg_weight, dv);
                yuanjia = Convert.ToDouble(dv[0, 0].Value.ToString());
                zhekou = good.doprice / yuanjia;
                string str_Add = "insert into goods_zhekou values(";
                str_Add += "'" + good.intg_ID + "','" + z_name + "','" + good.flg_weight + "','" + good.doprice + "','";
                str_Add += my_c_name + "','" + my_price + "','" + zhekou + "')";
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
        public int goods_UpDate(goods good)
        {
            int intFlag = 0;
            try
            {
                string str_Add = "update goods  set ";
                str_Add += "c_name='" + good.strc_name + "',z_ID=" + good.intz_ID ;
                str_Add += ",g_weight=" + good.flg_weight + ",price=" + good.doprice;
                str_Add += " where g_ID =" + good.intg_ID ;

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
        public int goods_Delete(goods good)
        {
            int intFlag = 0;
            try
            {
                //string str_Add = "update tb_CompanyInfo  set ";
                //str_Add += "Flag='" + Company.intFlag + "' where CompanyID ='" + Company.intCompanyID + "'";

                string str_Delete = "delete from goods where g_ID=" + good.intg_ID + "";
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
        public void goodsMethods_Find(string strObject, Object DataObject)
        {
            try
            {
                string strSecar = null;
                strSecar = "select * from goods"; //查询所有信息

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
                    int z_ID=1;
                    dv.RowCount = ii;
                    qlddr = cmd.ExecuteReader();
                    while (qlddr.Read())
                    {
                        dv[0, i].Value = Convert.ToInt32(qlddr[0].ToString());
                        dv[1, i].Value = qlddr[1].ToString();
                        z_ID = Convert.ToInt32(qlddr[2].ToString());
                        dv[2, i].Value = z_ID;
                        dv[3, i].Value = Convert.ToDouble(qlddr[3].ToString());
                        dv[4, i].Value = Convert.ToDouble(qlddr[4].ToString());
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
                            dv[4, i].Value = "";
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

        #region 查询2（用于加载窗体；添加，修改和删除后显示更新的信息）
        public void goodsMethods_Find2(string strObject, Object DataObject)
        {
            try
            {
                string strSecar = null;
                strSecar = "select c_name,z_name,goods.g_weight,goods.price,new_c_name,new_price from goods,goods_zhekou where goods.g_ID = goods_zhekou.g_ID"; //查询所有信息

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
                        dv[2, i].Value = Convert.ToDouble(qlddr[2].ToString());
                        dv[3, i].Value = Convert.ToDouble(qlddr[3].ToString());
                        dv[4, i].Value = qlddr[4].ToString();
                        dv[5, i].Value = Convert.ToDouble(qlddr[5].ToString());
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
                            dv[4, i].Value = "";
                            dv[5, i].Value = "";
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

        #region 查询3（用于加载窗体；添加，修改和删除后显示更新的信息）
        public double goodsMethods_Find3(string strObject, Object DataObject)
        {
            try
            {
                string strSecar = null;
                strSecar = "select * from goods_zhekou where new_price<price"; //查询所有信息

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

                double ot_zhekou,my_zhekou,my_price,ot_price;
                double yuanjia,maxprice,interest, interestRate;
                double interestSum=0;
                if (ii != 0)
                {
                    int i = 0;
                    dv.RowCount = ii;
                    qlddr = cmd.ExecuteReader();
                    while (qlddr.Read())
                    {
                        ot_zhekou = Convert.ToDouble(qlddr[6].ToString());
                        my_price = Convert.ToDouble(qlddr[5].ToString());
                        ot_price = Convert.ToDouble(qlddr[3].ToString());
                        yuanjia = ot_price / ot_zhekou;
                        maxprice = yuanjia * ot_zhekou;
                        interest = maxprice - my_price;
                        interestSum += interest;
                        interestRate = interest / my_price * 100;
                        my_zhekou = my_price / ot_price * ot_zhekou * 10;
                        ot_zhekou *= 10;
                        my_zhekou = Math.Round(my_zhekou, 4);
                        ot_zhekou = Math.Round(ot_zhekou, 4);
                        interest = Math.Round(interest, 4);
                        interestRate = Math.Round(interestRate, 4);
                        dv[0, i].Value = qlddr[4].ToString();
                        dv[1, i].Value = my_price;
                        dv[2, i].Value = my_zhekou.ToString()+"折";
                        dv[3, i].Value = interest;
                        dv[4, i].Value = interestRate.ToString()+"%";
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
                return interestSum;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                return 0;
            }
        }
        #endregion

        #region 查询4（用于加载窗体；添加，修改和删除后显示更新的信息）
        public void goodsMethods_Find4(string strObject, Object DataObject)
        {
            try
            {
                string strSecar = null;
                strSecar = "select new_c_name,new_price,zhekou,price from goods_zhekou where new_price>=price"; //查询所有信息

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

                Double ot_zhekou, my_zhekou, my_price, ot_price;
                if (ii != 0)
                {
                    int i = 0;
                    dv.RowCount = ii;
                    qlddr = cmd.ExecuteReader();
                    while (qlddr.Read())
                    {
                        ot_zhekou = Convert.ToDouble(qlddr[2].ToString());
                        my_price = Convert.ToDouble(qlddr[1].ToString());
                        ot_price = Convert.ToDouble(qlddr[3].ToString());
                        my_zhekou = my_price / ot_price * ot_zhekou * 10;
                        ot_zhekou *= 10;
                        my_zhekou = Math.Round(my_zhekou, 4);
                        ot_zhekou = Math.Round(ot_zhekou, 4);
                        dv[0, i].Value = qlddr[0].ToString();
                        dv[1, i].Value = my_zhekou.ToString() + "折";
                        dv[2, i].Value = ot_zhekou.ToString() + "折";
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

        #region 查询5（用于加载窗体；添加，修改和删除后显示更新的信息）
        public void goodsMethods_Find5(string strObject, Object DataObject1, Object DataObject2)
        {
            try
            {
                string strSecar = null;
                strSecar = "select * from goods_zhekou where new_price<price"; //查询所有信息

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

                System.Windows.Forms.DataGridView dv1 = (DataGridView)DataObject1;
                System.Windows.Forms.DataGridView dv2 = (DataGridView)DataObject2;

                string area, vendor;
                List<string> areaList = new List<string>();
                List<int> areaCnt = new List<int>();
                List<string> vendorList = new List<string>();
                List<int> vendorCnt = new List<int>();

                if (ii != 0)
                {
                    int i = 0;
                    qlddr = cmd.ExecuteReader();
                    while (qlddr.Read())
                    {
                        area = qlddr[1].ToString();
                        vendor = qlddr[4].ToString();

                        int j;
                        for (j = 0; j < areaList.Count; j++)
                            if (area == areaList[j]) break;
                        if (j == areaList.Count)
                        {
                            areaList.Add(area);
                            areaCnt.Add(1);
                        }
                        else
                            areaCnt[j]++;

                        for (j = 0; j < vendorList.Count; j++)
                            if (vendor == vendorList[j]) break;
                        if (j == vendorList.Count)
                        {
                            vendorList.Add(vendor);
                            vendorCnt.Add(1);
                        }
                        else
                            vendorCnt[j]++;
                    }
                    qlddr.Close();

                    dv1.RowCount = areaList.Count;
                    dv2.RowCount = vendorList.Count;

                    double areaSum=0,vendorSum=0;
                    for (i = 0; i < areaList.Count; i++) areaSum += areaCnt[i];
                    for (i = 0; i < vendorList.Count; i++) vendorSum += vendorCnt[i];

                    double percent;
                    for (i = 0; i < dv1.RowCount; i++)
                    {
                        dv1[0, i].Value = areaList[i];
                        //percent = Convert.ToDouble(areaCnt[i]) / areaList.Count;
                        percent = areaCnt[i] / areaSum * 100;
                        percent = Math.Round(percent, 4);
                        dv1[1, i].Value = percent.ToString() + "%";
                    }

                    for (i = 0; i < dv2.RowCount; i++)
                    {
                        dv2[0, i].Value = vendorList[i];
                        //percent = Convert.ToDouble(vendorCnt[i]) / vendorList.Count;
                        percent = vendorCnt[i] / vendorSum * 100;
                        percent = Math.Round(percent, 4);
                        dv2[1, i].Value = percent.ToString() + "%";
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
        public SqlDataReader goodsMethods_Find(int ID, int intFlag)
        {
            string strSecar = null;

            try
            {
                switch (intFlag)//判断条件
                {
                    case 1://根据商品编号查询
                        strSecar = "select * from goods where g_ID = " + ID ;
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
