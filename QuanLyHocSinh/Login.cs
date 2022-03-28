using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class fLogin : Form
    {
        public static string globalUsername = "";
        public string GetUsername()
        {

            return globalUsername;
        }
        public fLogin()
        {
            InitializeComponent();
        }

        private void lbForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã click quên mật khẩu!");
        }

        private void lbRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã click đăng ký!");
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Database db = new Database();
            String getUsername = txtUsername.Text;
            String getPassword = txtPassword.Text;

            
            dt = db.GetData($"SELECT * FROM [StudentManagement].[dbo].[User] WHERE USERNAME ='{getUsername}' AND PASSWORD = '{getPassword}'");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show($"Đăng nhập với tài khoản [{getUsername}] thành công !");
                globalUsername = txtUsername.Text;
                var DrashBoard = new MainForm();
                DrashBoard.Show();
                this.Hide();

            }
                
            else
                MessageBox.Show($"Đăng nhập thất bại, vui lòng kiểm tra lại tài khoản và mật khẩu !");
        }

        private void linkForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            
            var Recover = new Recover();
            Recover.Show();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            var Register = new Register();
            Register.Show();
        }
    }
}
