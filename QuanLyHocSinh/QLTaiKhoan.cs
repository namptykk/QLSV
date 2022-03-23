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
    public partial class QLTaiKhoan : Form
    {

        public static String query = "";
        public static String getStatus = "";
        public QLTaiKhoan()
        {
            InitializeComponent();

        }

        private void QLTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadData();
            ReadOnly();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void dgvAccount_SelectionChanged(object sender, EventArgs e)
        {
            String getAdmin = dgvAccount.Rows[dgvAccount.CurrentCell.RowIndex].Cells["isAdmin"].Value.ToString();

            txtID.Text = dgvAccount.Rows[dgvAccount.CurrentCell.RowIndex].Cells["ID"].Value.ToString();
            txtUsername.Text = dgvAccount.Rows[dgvAccount.CurrentCell.RowIndex].Cells["Username"].Value.ToString();
            txtPassword.Text = dgvAccount.Rows[dgvAccount.CurrentCell.RowIndex].Cells["Password"].Value.ToString();
            txtFullname.Text = dgvAccount.Rows[dgvAccount.CurrentCell.RowIndex].Cells["FullName"].Value.ToString();
            txtCreatedDate.Text = dgvAccount.Rows[dgvAccount.CurrentCell.RowIndex].Cells["CreatedDate"].Value.ToString();
            txtEmail.Text = dgvAccount.Rows[dgvAccount.CurrentCell.RowIndex].Cells["Email"].Value.ToString();

            if (getAdmin != "")
                checkBoxAdmin.Checked = true;
            else
                checkBoxAdmin.Checked = false;
        }


        void LoadData()
        {
            DataTable dt = new DataTable();
            Database db = new Database();
            dt = db.GetData($"SELECT * FROM [StudentManagement].[dbo].[User]");
            dgvAccount.DataSource = dt;
        }

        void ReadOnly()
        {
            txtID.ReadOnly = true;
            txtUsername.ReadOnly = true;
            txtPassword.ReadOnly = true;
            txtFullname.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtCreatedDate.ReadOnly = true;
            checkBoxAdmin.Enabled = false;
            btnConfirm.Enabled = false;

        }

        void Enable()
        {
            txtID.ReadOnly = false;
            txtUsername.ReadOnly = false;
            txtPassword.ReadOnly = false;
            txtFullname.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtCreatedDate.ReadOnly = false;
            checkBoxAdmin.Enabled = true;
            btnConfirm.Enabled = true;

        }

        void ClearTextBox()
        {
            txtID.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtFullname.Text = "";
            txtCreatedDate.Text = "";
            txtEmail.Text = "";
            checkBoxAdmin.Checked = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtUsername.ReadOnly == true)
            {
                btnEdit.Text = "Hủy bỏ";
                Enable();
            }
                
            else
            {
                btnEdit.Text = "Sửa";
                ReadOnly();
            }

            string getChecked = "";
            if (checkBoxAdmin.Checked == true)
            {
                getChecked = "Y";
            }
            else
                getChecked = "N";
            
            getStatus = "Update";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thực thi?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string getChecked = "";
                if (checkBoxAdmin.Checked == true)
                    getChecked = "Y";
                else
                    getChecked = "N";

                Database db = new Database();
                if(getStatus == "Insert")
                {
                    query = $"INSERT INTO [StudentManagement].[dbo].[User](Username,Password,FullName,Email,CreatedDate,isAdmin) " +
                                $" VALUES('{txtUsername.Text}','{txtPassword.Text}','{txtFullname.Text}','{txtEmail.Text}',getdate(),'{getChecked}')";
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnAdd.Text = "Thêm";
                }
                if(getStatus == "Update")
                {
                    query = $"UPDATE [StudentManagement].[dbo].[User] SET Username = '{txtUsername.Text}', Password='{txtPassword.Text}', " +
                                $"Fullname='{txtFullname.Text}', Email='{txtEmail.Text}', isAdmin='{getChecked}' WHERE ID = '{txtID.Text}'";
                    btnEdit.Text = "Sửa";
                }
                db.UpdateData(query);
                LoadData();
                ReadOnly();

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show("Cập nhật dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Thêm")
            {
                ClearTextBox();
                txtID.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                txtCreatedDate.Text = DateTime.Now.ToString("M/dd/yyyy H:MM:ss");
                Enable();
                getStatus = "Insert";
                btnAdd.Text = "Hủy thêm";
            }
            else
            {
                LoadData();
                ReadOnly();
                btnAdd.Text = "Thêm";
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thực thi?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                query = $"DELETE [StudentManagement].[dbo].[User] WHERE ID ='{txtID.Text}'";
                Database db = new Database();
                db.UpdateData(query);
                LoadData();
                ReadOnly();
            }
        }
    }
}
