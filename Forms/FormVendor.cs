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
    public partial class FormVendor : Form
    {
        string fromTb;
        public FormVendor(string from) //从哪张表过来的
        {
            InitializeComponent();
            fromTb = from;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        companyMethods cmpMethod = new companyMethods();
        private void FormVendor_Load(object sender, EventArgs e)
        {
            cmpMethod.filltProd(this.treeView1, imageList1);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Text != "")
            {
                switch (fromTb)
                {
                    case "GoodsInfo":
                        FormGoodsInfo GoodsInfo = (FormGoodsInfo)this.Owner;
                        GoodsInfo.textVendor.Text = treeView1.SelectedNode.Text;
                        break;
                    case "ExtraInfo":
                        FormExtraInfo ExtraInfo = (FormExtraInfo)this.Owner;
                        ExtraInfo.textVendor.Text = treeView1.SelectedNode.Text;
                        break;
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("选择渠道商名称");
            }
        }
    }
}
