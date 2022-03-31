using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QuanLyHocSinh
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Login = new fLogin();
            Login.Show();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            bool checkInputed = true;
            string query = "";

            List<TextBox> inputList = new List<TextBox>();
            inputList.Add(txtUsername);
            inputList.Add(txtPassword);
            inputList.Add(txtPasswordAgain);
            inputList.Add(txtFullName);
            inputList.Add(txtEmail);

            foreach (TextBox tb in inputList)
            {
                if(tb.Text == "")
                {
                    checkInputed = false;
                    break;
                }

            }

            if (checkInputed)
            {
            
                Match checkMatch = reg.Match(txtEmail.Text);

                // Check passwords are same
                if (!txtPassword.Text.Equals(txtPasswordAgain.Text))
                    MessageBox.Show("Nhập lại mật khẩu chưa đúng !", "Thông báo", MessageBoxButtons.OK);
                // Check email valid
                else if(!checkMatch.Success)
                    MessageBox.Show("Địa chỉ Email sai format !", "Thông báo", MessageBoxButtons.OK);
                else
                {
                    // check username already exist
                    Database db = new Database();
                    DataTable dt = new DataTable();
                    query = $"SELECT * FROM [StudentManagement].[dbo].[User] WHERE USERNAME ='{txtUsername.Text}'";
                    dt = db.GetData(query);
                    if(dt.Rows.Count < 1)
                    {
                        // Insert data into database
                        query = $"INSERT into[StudentManagement].[dbo].[User](Username, Password, FullName, Email, CreatedDate) " +
                                        $"VALUES('{txtUsername.Text}', '{txtPassword.Text}', '{txtFullName.Text}', '{txtEmail.Text}', getdate())";
                        db.UpdateData(query, "Tạo tài khoản thành công !");
                         clearValue();
                    }
                    else
                        MessageBox.Show("Tài khoản này đã tồn tại trong hệ thống !", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
            clearValue();

        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            clearValue();
        }

        void clearValue()
        {
            List<TextBox> inputList = new List<TextBox>();
            inputList.Add(txtUsername);
            inputList.Add(txtPassword);
            inputList.Add(txtPasswordAgain);
            inputList.Add(txtFullName);
            inputList.Add(txtEmail);

            foreach (TextBox tb in inputList)
            {
                tb.Text = "";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }   
}
