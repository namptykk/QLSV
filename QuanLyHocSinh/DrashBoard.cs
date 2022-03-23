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
    public partial class DrashBoard : Form
    {
        public DrashBoard()
        {
            InitializeComponent();
          lbAccount.Text = "Xin chào - " + fLogin.globalUsername;
        }

        private void DrashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void DrashBoard_Load(object sender, EventArgs e)
        {
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            closeOpeningForm();
            Home f = new Home() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            f.FormBorderStyle = (FormBorderStyle)0;
            
            tableDisplay.Controls.Add(f);
            f.Show();

        }

        private void btnQLSV_Click(object sender, EventArgs e)
        {
            closeOpeningForm();
            NhapSinhVien f = new NhapSinhVien() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            f.FormBorderStyle = (FormBorderStyle)0;
            tableDisplay.Controls.Add(f);
            f.Show();
        }

        void closeOpeningForm()
        {
            //foreach(Form form in Application.OpenForms)
            //{
            //    if(form.Name != "DrashBoard")
            //    {
            //        form.Activate();
            //        form.Show();
            //        this.Close();
            //        return;
            //    }
            //}

        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            closeOpeningForm();
            QLTaiKhoan f = new QLTaiKhoan() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            f.FormBorderStyle = (FormBorderStyle)0;
            tableDisplay.Controls.Add(f);
            f.ShowDialog();
        }

        private void btnQLKL_Click(object sender, EventArgs e)
        {
            closeOpeningForm();
            QLKhoaLop f = new QLKhoaLop() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            f.FormBorderStyle = (FormBorderStyle)0;
            tableDisplay.Controls.Add(f);
            f.Show();
        }

        private void btnQLDT_Click(object sender, EventArgs e)
        {
            closeOpeningForm();
            QLDiem f = new QLDiem() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            f.FormBorderStyle = (FormBorderStyle)0;
            tableDisplay.Controls.Add(f);
            f.Show();
        }

        private void btnQLMH_Click(object sender, EventArgs e)
        {
            closeOpeningForm();
            QLMH f = new QLMH() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            f.FormBorderStyle = (FormBorderStyle)0;
            tableDisplay.Controls.Add(f);
            f.Show();
        }

        private void btnQLGV_Click(object sender, EventArgs e)
        {
            closeOpeningForm();
            QLGV f = new QLGV() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            f.FormBorderStyle = (FormBorderStyle)0;
            tableDisplay.Controls.Add(f);
            f.Show();
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var fLogin = new fLogin();
            fLogin.Show();
        }
    }
}
