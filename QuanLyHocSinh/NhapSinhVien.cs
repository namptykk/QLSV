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
          
            Database db = new Database();
            String MSSV = getMSSV();
            string pathSaveImage = @"D:\TEST\QLSV\QuanLyHocSinh\Image 3x4\" + MSSV + Path.GetExtension(fileName);
    
            List<String> listValue = getValue();

            String query = $"INSERT INTO [StudentManagement].[dbo].[SinhVien](MaSinhVien,TenSinhVien,GioiTinh,NgaySinh,QueQuan,SDT,MaLop,HinhAnh) " +
                $"  VALUES('{MSSV}',N'{listValue[1]}',N'{listValue[2]}',N'{listValue[3]}',N'{listValue[4]}',N'{listValue[5]}',N'{listValue[6]}','{pathSaveImage}')";
            Console.Write(query);
            db.UpdateData(query,"Thêm sinh viên thành công !");
            clearValue();

            // Move file image
            pictureAvatar.Image = null;
            if (File.Exists(fileName) == true)
            {
                File.Copy(fileName, pathSaveImage,true);
            }


            txtMaSV.Text = getMSSV();
            pictureAvatar.Image = null;
            
        }
        private void NhapSinhVien_Load(object sender, EventArgs e)
        {
            String MSSV = getMSSV();
            txtMaSV.Text = MSSV;
            addMaLop();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearValue();
            txtMaSV.Text = getMSSV();
            pictureAvatar.Image = null;
        }


        // CUSTOM FUNCTION
            // Get value from textbox
        List<String> getValue()
        {
            List<Control> listTextbox = new List<Control>()
            {txtMaSV,txtTenSV,cbGioiTinh,txtNgaySinh,txtQueQuan,txtSDT,cbMaLop};

            List<String> listValue = new List<string>();
            foreach (Control ct in listTextbox)
            {
                listValue.Add(ct.Text);
            }
            return listValue;
        }
            // Clear value in textbox
        void clearValue()
        {
            List<Control> listTextbox = new List<Control>()
            {txtMaSV,txtTenSV,cbGioiTinh,txtNgaySinh,txtQueQuan,txtSDT,cbMaLop};

            List<String> listValue = new List<string>();
            foreach (Control ct in listTextbox)
            {
                ct.Text = "";
            }
            pictureAvatar.Image = null;
        }
            // Count Student -> Return new Student ID
        String getMSSV()
        {
            String MSSV = "SV00000000";
            Database db = new Database();
            DataTable dt = db.GetData("SELECT * FROM [StudentManagement].[dbo].[SinhVien]");
            int countRow = dt.Rows.Count + 1;
            MSSV = MSSV.Substring(0, MSSV.Length - countRow.ToString().Length) + countRow.ToString();
            Console.WriteLine(MSSV);

            return MSSV;
        }
            // Get list of Class ID
        void addMaLop()
        {
            Database db = new Database();
            DataTable dt = db.GetData("SELECT * FROM [StudentManagement].[dbo].[Lop]");
            foreach (DataRow dr in dt.Rows)
            {
                cbMaLop.Items.Add(dr[0].ToString());
            }
        }
        // END CUSTOM FUNCTION
    }
}
