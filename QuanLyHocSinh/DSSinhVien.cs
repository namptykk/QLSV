using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuanLyHocSinh
{
    public partial class DSSinhVien : Form
    {
        public static string fileName = "";
        public static bool updateImage = false;
        public DSSinhVien()
        {
            InitializeComponent();
        }

        private void btnAddSinhVien_Click(object sender, EventArgs e)
        {
            Form new_mdi_child = new NhapSinhVien();
            new_mdi_child.Show();
        }

        private void DSSinhVien_Load(object sender, EventArgs e)
        {
            btnApply.Enabled = false;
            disableTextBox();
            LoadData();
            //if (File.Exists(@"D:\TEST\QLSV\QuanLyHocSinh\Image 3x4\" + txtMaSV.Text + ".jpg") == true)
            //{
            //    Image im = GetCopyImage(@"D:\TEST\QLSV\QuanLyHocSinh\Image 3x4\" + txtMaSV.Text + ".jpg");
            //    pictureAvatar.Image = im;
            //}
            //else
            //    pictureAvatar.Image = null;
        }

        void LoadData()
        {
            DataTable dt = new DataTable();
            Database db = new Database();
            dt = db.GetData($"SELECT MaSinhVien,TenSinhVien,GioiTinh,NgaySinh,QueQuan,SDT,MaLop FROM [StudentManagement].[dbo].[SinhVien]");
            dgvDisplay.DataSource = dt;
        }

        private void dgvDisplay_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvDisplay.Rows.Count > 0)
                {
                    txtMaSV.Text = dgvDisplay.Rows[dgvDisplay.CurrentCell.RowIndex].Cells["MaSinhVien"].Value.ToString();
                    txtTenSV.Text = dgvDisplay.Rows[dgvDisplay.CurrentCell.RowIndex].Cells["TenSinhVien"].Value.ToString();
                    txtGioiTinh.Text = dgvDisplay.Rows[dgvDisplay.CurrentCell.RowIndex].Cells["GioiTinh"].Value.ToString();
                    txtNgaySinh.Text = dgvDisplay.Rows[dgvDisplay.CurrentCell.RowIndex].Cells["NgaySinh"].Value.ToString();
                    txtQueQuan.Text = dgvDisplay.Rows[dgvDisplay.CurrentCell.RowIndex].Cells["QueQuan"].Value.ToString();
                    txtSDT.Text = dgvDisplay.Rows[dgvDisplay.CurrentCell.RowIndex].Cells["SDT"].Value.ToString();
                    txtMaLop.Text = dgvDisplay.Rows[dgvDisplay.CurrentCell.RowIndex].Cells["MaLop"].Value.ToString();

                    if (File.Exists(@"D:\TEST\QLSV\QuanLyHocSinh\Image 3x4\" + txtMaSV.Text + ".jpg") == true)
                    {
                        Image im = GetCopyImage(@"D:\TEST\QLSV\QuanLyHocSinh\Image 3x4\" + txtMaSV.Text + ".jpg");
                        pictureAvatar.Image = im;
                    }
                    else
                        pictureAvatar.Image = null;
                }
            }
            catch(Exception )
            {
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "";
            DialogResult dialogResult = MessageBox.Show($"Bạn có chắc muốn xóa sinh viên: {txtMaSV.Text}", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                query = $"DELETE [StudentManagement].[dbo].[SinhVien] WHERE MaSinhVien ='{txtMaSV.Text}'";
                Database db = new Database();
                db.UpdateData(query);
                LoadData();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show($"Cập nhật dữ liệu thành công !");
        }

        void disableTextBox()
        {
            txtMaSV.Enabled = false;
            txtTenSV.Enabled = false;
            txtGioiTinh.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtQueQuan.Enabled = false;
            txtSDT.Enabled = false;
            txtMaLop.Enabled = false;
            txtChuyenNganh.Enabled = false;
        }
        void enableTextBox()
        {
            txtTenSV.Enabled = true;
            txtGioiTinh.Enabled = true;
            txtNgaySinh.Enabled = true;
            txtQueQuan.Enabled = true;
            txtSDT.Enabled = true;
            txtMaLop.Enabled = true;
            txtChuyenNganh.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(btnEdit.Text == "Sửa")
            {
                btnEdit.Text = "Hủy";
                btnApply.Enabled = true;
                enableTextBox();
            }
            else
            {
                btnEdit.Text = "Sửa";
                btnApply.Enabled = false;
                disableTextBox();
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string query = "";
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thực thi?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                query = $"UPDATE [StudentManagement].[dbo].[SinhVien] SET TENSINHVIEN = N'{txtTenSV.Text}', GIOITINH = N'{txtGioiTinh.Text}', NGAYSINH = '{txtNgaySinh.Text}', QUEQUAN = N'{txtQueQuan.Text}', SDT = '{txtSDT.Text}', MALOP = '{txtMaLop.Text}' " +
                    $"WHERE MaSinhVien ='{txtMaSV.Text}'";
                Database db = new Database();
                db.UpdateData(query);
                disableTextBox();
                btnEdit.Text = "Sửa";
                btnApply.Enabled = false;

                string pathSaveImage = @"D:\TEST\QLSV\QuanLyHocSinh\Image 3x4\" + txtMaSV.Text + Path.GetExtension(fileName);

                if (File.Exists(fileName) == true)
                {
                    File.Copy(fileName, pathSaveImage, true);
                }
                LoadData();
            }
        }

        private void pictureAvatar_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                updateImage = true;
                btnApply.Enabled = true;

                fileName = dlg.FileName;
                Image im = GetCopyImage(fileName);
                pictureAvatar.Image = im;

                
                //pictureAvatar.Image = Image.FromFile(fileName);
            }
        }

        private Image GetCopyImage(string path)
        {
            using (Image im = Image.FromFile(path))
            {
                Bitmap bm = new Bitmap(im);
                return bm;
            }
        }
    }
}
