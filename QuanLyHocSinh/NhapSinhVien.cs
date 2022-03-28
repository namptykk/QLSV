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
    public partial class NhapSinhVien : Form
    {
        public static string fileName = "";
        public NhapSinhVien()
        { 
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                
                fileName = dlg.FileName;
                pictureAvatar.Image = Image.FromFile(fileName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<String> listValue = getValue();
            Database db = new Database();
            String getImagePath = pictureAvatar.ImageLocation;
            String query = $"INSERT INTO [StudentManagement].[dbo].[SinhVien](MaSinhVien,TenSinhVien,GioiTinh,NgaySinh,QueQuan,SDT,MaLop,HinhAnh) " +
                $"  VALUES('{listValue[0]}','{listValue[1]}','{listValue[2]}','{listValue[3]}','{listValue[4]}','{listValue[5]}','{listValue[6]}','{fileName}')";
            db.UpdateData(query);
            Console.WriteLine(query);
        }

        List<String> getValue()
        {
            List<Control> listTextbox = new List<Control>()
            {txtMaSV,txtTenSV,cbGioiTinh,txtNgaySinh,txtQueQuan,txtSDT,txtMaLop};

            List<String> listValue = new List<string>();
            foreach(Control ct in listTextbox)
            {
                listValue.Add(ct.Text);
            }
            return listValue;
        }
    }
}
