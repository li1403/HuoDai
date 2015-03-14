using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HuoDai.DBMethods;
using System.Data.SqlClient;
using HuoDai.ClassInfos;
using System.IO;
using System.Data.OleDb;

namespace WindowsFormsApplication1.Forms
{
    public partial class FormGoodsInfo : Form
    {
        public FormGoodsInfo()
        {
            InitializeComponent();
        }

        private void btnVendorSelect_Click(object sender, EventArgs e)
        {
            FormVendor Vendor = new FormVendor("GoodsInfo");
            Vendor.Owner = this;
            Vendor.ShowDialog();
        }

        private void btnAreaSlecet_Click(object sender, EventArgs e)
        {
            FormArea Area = new FormArea("GoodsInfo");
            Area.Owner = this;
            Area.ShowDialog();
        }

        private void FormGoodsInfo_Load(object sender, EventArgs e)
        {
            gdMethod.goodsMethods_Find("", dataGridView1);
        }

        public static int intFlag = 0;
        public static int intReturn = 0;
        goods gd = new goods();
        goodsMethods gdMethod = new goodsMethods();
        zoneMethods zMethod = new zoneMethods();
        
        #region 辅助函数
        private void ClearControls()// 将文本框内容恢复到原始状态
        {
            textVendor.Text = "";
            textID.Text = "";
            textArea.Text = "";
            textWeight.Text = "";
            textPrice.Text = "";
        }

        private void FillControls()//用来单击网格中单元格时将该记录信息填充到网格上方信息区
        {
            try
            {

                SqlDataReader sqldr = gdMethod.goodsMethods_Find
                    (int.Parse(this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex].Value.ToString()), 1);

                sqldr.Read();
                if (sqldr.HasRows)
                {
                    textID.Text = sqldr[0].ToString();
                    textVendor.Text = sqldr[1].ToString();
                    //SqlDataReader temp = zMethod.zoneMethods_Find(sqldr[2].ToString());
                    string temp = zMethod.zoneMethods_Find(sqldr[2].ToString());
                    textArea.Text = temp;
                    textWeight.Text = sqldr[3].ToString();
                    textPrice.Text = sqldr[4].ToString();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        public int GetCount() //获取界面中的信息
        {
            int intReslult = 0;
            if (intFlag == 1 || intFlag == 2)//要添加或修改时
            {
                if (textID.Text == "")
                {
                    MessageBox.Show("货物编号不能为空！", "提示");
                    return intReslult;
                }
                if (textVendor.Text == "")
                {
                    MessageBox.Show("渠道商名称不能为空！", "提示");
                    return intReslult;
                }
                if (textArea.Text == "")
                {
                    MessageBox.Show("发往区域不能为空！", "提示");
                    return intReslult;
                }
                if (textWeight.Text == "")
                {
                    MessageBox.Show("货物重量不能为空！", "提示");
                    return intReslult;
                }
                if (textPrice.Text == "")
                {
                    MessageBox.Show("货物运费不能为空！", "提示");
                    return intReslult;
                }
                gd.intg_ID = int.Parse(textID.Text);
                //MessageBox.Show(zMethod.zoneMethods_Find(textArea.Text));
                gd.intz_ID = zMethod.zoneMethods_Find(textArea.Text,textVendor.Text);
                //MessageBox.Show(gd.intz_ID.ToString());
                gd.strc_name = textVendor.Text;
                gd.flg_weight = Single.Parse(textWeight.Text);
                gd.doprice = Double.Parse(textPrice.Text);
            }
            if (intFlag == 3)//若是删除
            {
                if (textID.Text == "")
                {
                    MessageBox.Show("货物不能为空！请选择要删除的的记录", "提示");
                    return intReslult;
                }
                gd.intg_ID = int.Parse(textID.Text);
            }
            intReslult = 1;
            return intReslult;

        }
        #endregion

        #region 按钮事件
        private void btnAdd_Click(object sender, EventArgs e)
        {
            intFlag = 1;
            if (GetCount() == 1)
            {
                if (gd.intg_ID < 0)
                {
                    MessageBox.Show("货物编号不能为负！", "提示");
                }
                else if (gdMethod.goodsMethods_Find(gd.intg_ID,1).Read())
                {
                    MessageBox.Show("不能添加编号相同的货物！", "提示");
                }
                else if (gd.intz_ID < 0)
                {
                    MessageBox.Show("该区域选择的渠道商不能到达，请重新选择。", "提示");
                }
                else if (gdMethod.goods_Add(gd) == 1)
                {
                    //if (gdMethod.goods_zhekou_Add(gd) == 1)
                    MessageBox.Show("添加成功");
                    intFlag = 0;
                    gdMethod.goodsMethods_Find("", dataGridView1);
                    ClearControls();
                }
                else
                {
                    MessageBox.Show("添加失败");
                    intFlag = 0;
                    gdMethod.goodsMethods_Find("", dataGridView1);
                    ClearControls();
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            intFlag = 2;
            if (GetCount() == 1)
            {
                if (!gdMethod.goodsMethods_Find(gd.intg_ID, 1).Read())
                {
                    MessageBox.Show("要修改的条目不存在。", "提示");
                }
                else if (gdMethod.goods_UpDate(gd) == 1)
                {
                    MessageBox.Show("修改成功");
                    intFlag = 0;
                    gdMethod.goodsMethods_Find("", dataGridView1);
                    ClearControls();
                }
                else
                {
                    MessageBox.Show("修改失败");
                    intFlag = 0;
                    gdMethod.goodsMethods_Find("", dataGridView1);
                    ClearControls();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            intFlag = 3;
            if (GetCount() == 1)
            {
                if (!gdMethod.goodsMethods_Find(gd.intg_ID, 1).Read())
                {
                    MessageBox.Show("要删除的条目不存在。", "提示");
                }
                else if (gdMethod.goods_Delete(gd) == 1)
                {
                    MessageBox.Show("删除成功");
                    intFlag = 0;
                    gdMethod.goodsMethods_Find("", dataGridView1);
                    ClearControls();
                }
                else
                {
                    MessageBox.Show("删除失败");
                    intFlag = 0;
                    gdMethod.goodsMethods_Find("", dataGridView1);
                    ClearControls();
                }
            }
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)//单击网格单元格时，调用FillControls函数
        {
            FillControls();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FillControls();
        }
        #endregion

    }
}
