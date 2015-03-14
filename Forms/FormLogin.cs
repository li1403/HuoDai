using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using HuoDai.DBMethods;
using WindowsFormsApplication1.Forms;

namespace HuoDai.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.skinEngine1.SkinFile = "E:/数据库项目/WindowsFormsApplication1/WindowsFormsApplication1/Skin/MidsummerColor2.ssk";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (textID.Text == "")
            {
                MessageBox.Show("用户名不能为空！");
                return;
            }
            if (textPwd.Text == "")
            {
                MessageBox.Show("密码不能为空！");
                return;
            }
            if (textID.Text == "admin" && textPwd.Text == "123456") //此处仅作测试，没有用户信息
            {
                FormMain frm = new FormMain();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("登录失败！");
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textPwd.PasswordChar = '*';
            textPwd.UseSystemPasswordChar = true;
        }

        private void textboxChanged(object sender, EventArgs e)
        {
            if (sender.Equals(textID))
            {
                label1.Visible = textID.Text.Length < 1;
            }
            else if (sender.Equals(textPwd))
            {
                label2.Visible = textPwd.Text.Length < 1;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (sender.Equals(label1))
            {
                textID.Focus();
            }
            else if (sender.Equals(label2))
            {
                textPwd.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (sender.Equals(label1))
            {
                textID.Focus();
            }
            else if (sender.Equals(label2))
            {
                textPwd.Focus();
            }
        }

    }
}
