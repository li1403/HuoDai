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

namespace WindowsFormsApplication1.Forms
{
    public partial class FormExtraInfo : Form
    {
        public FormExtraInfo()
        {
            InitializeComponent();
        }

        private void btnVendorSelect_Click(object sender, EventArgs e)
        {
            FormVendor Vendor = new FormVendor("ExtraInfo");
            Vendor.Owner = this;
            Vendor.ShowDialog();
        }

        public static int intFlag = 0;
        public static int intReturn = 0;
        extra_priceMethods exMethod = new extra_priceMethods();
        companyMethods cmpMethod = new companyMethods();
        extra_price exp = new extra_price();

        private void FormExtraInfo_Load(object sender, EventArgs e)
        {
            exMethod.extra_priceMethods_Find("", dataGridView1);
        }

        
        #region 辅助函数
        private void ClearControls()// 将文本框内容恢复到原始状态
        {
            textVendor.Text = "";
            textName.Text = "";
            comboBox1.Text = "";
            textValue.Text = "";
        }

        private void FillControls()//用来单击网格中单元格时将该记录信息填充到网格上方信息区
        {
            try
            {

                SqlDataReader sqldr = exMethod.extra_priceMethods_Find
                                        (this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex].Value.ToString(),
                                         this.dataGridView1[1, this.dataGridView1.CurrentCell.RowIndex].Value.ToString(), 1);

                sqldr.Read();
                if (sqldr.HasRows)
                {
                    textVendor.Text = sqldr[0].ToString();
                    textName.Text = sqldr[1].ToString();
                    switch (sqldr[2].ToString())
                    {
                        case "1": comboBox1.Text = "折扣";
                            break;
                        case "2": comboBox1.Text = "每单固定价格";
                            break;
                        case "3": comboBox1.Text = "每单比例价格";
                            break;
                    }
                    textValue.Text = sqldr[3].ToString();
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
                if (textVendor.Text == "")
                {
                    MessageBox.Show("渠道商名称不能为空！", "提示");
                    return intReslult;
                }
                if (textName.Text == "")
                {
                    MessageBox.Show("价目名称不能为空！", "提示");
                    return intReslult;
                }
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("价目类型不能为空！", "提示");
                    return intReslult;
                }
                if (comboBox1.Text != "折扣" && comboBox1.Text != "每单固定费用" && comboBox1.Text != "每单比例费用")
                {
                    MessageBox.Show("请从表单中选择价目类型！", "提示");
                    return intReslult;
                }
                if (textValue.Text == "")
                {
                    MessageBox.Show("价目数值不能为空！", "提示");
                    return intReslult;
                }
                //if (intFlag == 1)//若是添加，获取当前额外价目信息
                //{
                    exp.strc_name = textVendor.Text;
                    exp.stre_name = textName.Text;
                //}
                //else//若是修改，获取表中额外价目信息
                //{
                //    exp.strc_name = this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex].Value.ToString();
                //    exp.stre_name = this.dataGridView1[1, this.dataGridView1.CurrentCell.RowIndex].Value.ToString();
                //}
                switch (comboBox1.Text)
                {
                    case "折扣": exp.inte_type = 1;
                        break;
                    case "每单固定费用": exp.inte_type = 2;
                        break;
                    case "每单比例费用": exp.inte_type = 3;
                        break;
                }
                exp.doe_price = Convert.ToDouble(textValue.Text);
            }
            if (intFlag == 3)//若是删除
            {
                if (textVendor.Text == "")
                {
                    MessageBox.Show("渠道商名称不能为空！请选择要删除的的记录", "提示");
                    return intReslult;
                }
                if (textName.Text == "")
                {
                    MessageBox.Show("价目名称不能为空！请选择要删除的的记录", "提示");
                    return intReslult;
                }
                exp.strc_name = textVendor.Text;
                exp.stre_name = textName.Text;
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
                if (exMethod.extra_priceMethods_Find(exp.strc_name, exp.stre_name, 1).Read())
                {
                    MessageBox.Show("不能添加重名的项目！", "提示");
                }
                else if (!cmpMethod.companyMethods_Find(textVendor.Text.ToString(), 1).Read())
                {
                    MessageBox.Show("渠道商不存在，请从渠道商列表中选择。", "提示");
                }
                else if (exMethod.extra_price_Add(exp) == 1)
                {
                    MessageBox.Show("添加成功");
                    intFlag = 0;
                    exMethod.extra_priceMethods_Find("", dataGridView1);
                    ClearControls();
                }
                else
                {
                    MessageBox.Show("添加失败");
                    intFlag = 0;
                    exMethod.extra_priceMethods_Find("", dataGridView1);
                    ClearControls();
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            intFlag = 2;
            if (GetCount() == 1)
            {
                if (!exMethod.extra_priceMethods_Find(exp.strc_name,exp.stre_name,1).Read())
                {
                    MessageBox.Show("要修改的条目不存在。", "提示");
                }
                else if (exMethod.extra_price_UpDate(exp) == 1)
                {
                    MessageBox.Show("修改成功");
                    intFlag = 0;
                    exMethod.extra_priceMethods_Find("", dataGridView1);
                    ClearControls();
                }
                else
                {
                    MessageBox.Show("修改失败");
                    intFlag = 0;
                    exMethod.extra_priceMethods_Find("", dataGridView1);
                    ClearControls();
                }
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {

            intFlag = 3;
            if (GetCount() == 1)
            {
                if (!exMethod.extra_priceMethods_Find(exp.strc_name, exp.stre_name, 1).Read())
                {
                    MessageBox.Show("要删除的条目不存在。", "提示");
                }
                else if (exMethod.extra_price_Delete(exp) == 1)
                {
                    MessageBox.Show("删除成功");
                    intFlag = 0;
                    exMethod.extra_priceMethods_Find("", dataGridView1);
                    ClearControls();
                }
                else
                {
                    MessageBox.Show("删除失败");
                    intFlag = 0;
                    exMethod.extra_priceMethods_Find("", dataGridView1);
                    ClearControls();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)//单击网格单元格时，调用FillControls函数
        {
            FillControls();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)//单击单元格时
        {
            //FillControls();
        }
        #endregion

    }
}
