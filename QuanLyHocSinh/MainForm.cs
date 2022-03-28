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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Drashboard_Test_Load(object sender, EventArgs e)
        {
            checkAdmin();
        }

        private void menuAccount_Click(object sender, EventArgs e)
        {
            Form new_mdi_child = new QLTaiKhoan();
            new_mdi_child.Show();
        }

        private void menuDiem_Click(object sender, EventArgs e)
        {
            Form new_mdi_child = new QLDiem();
            //new_mdi_child.Text = "Cửa sổ con MDI";
            //new_mdi_child.MdiParent = this;
            new_mdi_child.Show();
        }

        private void menuChangePassword_Click(object sender, EventArgs e)
        {
            Form new_mdi_child = new ChangePassword();
            new_mdi_child.Show();
        }

        private void menuSignout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Form new_mdi_child = new fLogin();
                new_mdi_child.Show();
            }
        }


        void checkAdmin()
        {
            DataTable dt = new DataTable();
            Database db = new Database();
            String getUsername = fLogin.globalUsername;
            Console.WriteLine(getUsername);
            dt = db.GetData($"SELECT * FROM [StudentManagement].[dbo].[User] WHERE USERNAME ='{getUsername}' AND isAdmin ='Y'");
            if (dt.Rows.Count > 0)
            {
                menuNhapSinhVien.Enabled = true;
                menuAccount.Enabled = true;
                menuDiem.Enabled = true;
                menuDanhSachSinhVien.Enabled = true;
            }
                
            else
            {
                menuNhapSinhVien.Enabled = false;
                menuAccount.Enabled = false;
                menuDiem.Enabled = false;
                menuDanhSachSinhVien.Enabled = false;
            }
                
        }

        private void menuNhapSinhVien_Click(object sender, EventArgs e)
        {
            Form new_mdi_child = new NhapSinhVien();
            new_mdi_child.Show();
        }

        private void khoaLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
