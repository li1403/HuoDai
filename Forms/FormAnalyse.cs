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
    public partial class FormAnalyse : Form
    {
        public FormAnalyse()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormGoodsInfo GoodsInfo = new FormGoodsInfo();
            GoodsInfo.Owner = this;
            GoodsInfo.ShowDialog();
        }

        goodsMethods gdMethod = new goodsMethods();
        private void FormAnalyse_Load(object sender, EventArgs e)
        {
            gdMethod.goodsMethods_Find2("", dataGridView1);
            double interest = gdMethod.goodsMethods_Find3("", dataGridView2);
            textInterest.Text = interest.ToString();
            gdMethod.goodsMethods_Find4("", dataGridView3);
            gdMethod.goodsMethods_Find5("", dataGridView4, dataGridView5);
            Double percent = Convert.ToDouble(dataGridView2.RowCount) /dataGridView1.RowCount;
            percent = Math.Round(percent, 4);
            percent *= 100;
            textPercent.Text = percent.ToString() + "%";
        }
    }
}
