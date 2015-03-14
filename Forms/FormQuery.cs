using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HuoDai.DBMethods;

namespace WindowsFormsApplication1.Forms
{
    public partial class FormQuery : Form
    {
        public FormQuery()
        {
            InitializeComponent();
        }

        private void btnAreaSlecet_Click(object sender, EventArgs e)
        {
            FormArea Area = new FormArea("Query");
            Area.Owner = this;
            Area.ShowDialog();
        }

        priceMethods priceMethod = new priceMethods();
        zoneMethods zoneMethod = new zoneMethods();
        private void bntSearch_Click(object sender, EventArgs e)
        {
            if (textWeight.Text == "")
            {
                MessageBox.Show("请输入货物重量！");
                return;
            }
            if (textArea.Text == "")
            {
                MessageBox.Show("请选择货物发送区域！");
                return;
            }
            if (!zoneMethod.zoneMethods_Find(textArea.Text.ToString(), 1).Read())
            {
                MessageBox.Show("区域名称不存在，请从区域列表中选择。", "提示");
                return;
            }
            Single weight = Single.Parse(textWeight.Text);
            String area = textArea.Text;
            priceMethod.priceMethods_Find(weight, area, dataGridView1);
            textShowPrice.Text = dataGridView1[0, 0].Value.ToString();
        }
    }
}
