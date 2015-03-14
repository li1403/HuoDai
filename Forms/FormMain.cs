using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Forms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.skinEngine1.SkinFile = "E:/数据库项目/WindowsFormsApplication1/WindowsFormsApplication1/Skin/MidsummerColor2.ssk";
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        #region 单击不同菜单项，出现不同窗体
        private void btnQuery_Click(object sender, EventArgs e)
        {
            FormQuery Query = new FormQuery();
            Query.Owner = this;
            Query.ShowDialog();
        }

        private void btnAnalyse_Click(object sender, EventArgs e)
        {
            FormAnalyse Analyse = new FormAnalyse();
            Analyse.Owner = this;
            Analyse.ShowDialog();
        }

        private void btnGoodModify_Click(object sender, EventArgs e)
        {
            FormGoodsInfo GoodsInfo = new FormGoodsInfo();
            GoodsInfo.Owner = this;
            GoodsInfo.ShowDialog();
        }

        private void btnExtraModify_Click(object sender, EventArgs e)
        {
            FormExtraInfo ExtraInfo = new FormExtraInfo();
            ExtraInfo.Owner = this;
            ExtraInfo.ShowDialog();
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormQuery Query = new FormQuery();
            Query.Owner = this;
            Query.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormAnalyse Analyse = new FormAnalyse();
            Analyse.Owner = this;
            Analyse.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormExtraInfo ExtraInfo = new FormExtraInfo();
            ExtraInfo.Owner = this;
            ExtraInfo.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormGoodsInfo GoodsInfo = new FormGoodsInfo();
            GoodsInfo.Owner = this;
            GoodsInfo.ShowDialog();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("E:/数据库项目/WindowsFormsApplication1/WindowsFormsApplication1/Resources/btnQuery2.png");
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("E:/数据库项目/WindowsFormsApplication1/WindowsFormsApplication1/Resources/btnQuery21.png");
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("E:/数据库项目/WindowsFormsApplication1/WindowsFormsApplication1/Resources/btnQuery1.png");
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("E:/数据库项目/WindowsFormsApplication1/WindowsFormsApplication1/Resources/btnAnalyse2.bmp");
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("E:/数据库项目/WindowsFormsApplication1/WindowsFormsApplication1/Resources/btnAnalyse.bmp");
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Image = Image.FromFile("E:/数据库项目/WindowsFormsApplication1/WindowsFormsApplication1/Resources/btnExtra2.jpg");
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Image.FromFile("E:/数据库项目/WindowsFormsApplication1/WindowsFormsApplication1/Resources/btnExtra.jpg");
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Image = Image.FromFile("E:/数据库项目/WindowsFormsApplication1/WindowsFormsApplication1/Resources/btnGood.bmp");
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Image.FromFile("E:/数据库项目/WindowsFormsApplication1/WindowsFormsApplication1/Resources/btnGood2.bmp");
        }

    }
}
