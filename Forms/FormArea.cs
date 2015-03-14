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
    public partial class FormArea : Form
    {
        string fromTb;
        public FormArea(string from)
        {
            InitializeComponent();
            fromTb = from;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Text != "")
            {
                switch (fromTb)
                {
                    case "Query":
                        FormQuery Query = (FormQuery)this.Owner;
                        Query.textArea.Text = treeView1.SelectedNode.Text;
                        break;
                    case "GoodsInfo":
                        FormGoodsInfo GoodsInfo = (FormGoodsInfo)this.Owner;
                        GoodsInfo.textArea.Text = treeView1.SelectedNode.Text;
                        break;
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("选择区域名称");
            }
        }

        zoneMethods zoneMethod = new zoneMethods();
        private void FormArea_Load(object sender, EventArgs e)
        {
            zoneMethod.filltProd(this.treeView1, imageList1);
        }


    }
}
