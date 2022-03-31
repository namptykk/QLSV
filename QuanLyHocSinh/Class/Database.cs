using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    class Database
    {
        string ConnectionString = "Data Source=10.246.194.75;Initial Catalog=StudentManagement;Persist Security Info=True;User ID=robotnt;Password=Password@123";
        SqlConnection con;

        //Call this method to open the connection.
        public void OpenConection()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
        }

        //Call this method to close the connection.
        public void CloseConnection()
        {
            con.Close();
        }

        //Call this method to perform insert, delete and update functions.
        public DataTable GetData(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConection();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(dt);

                if (dt.Rows.Count < 0)
                    MessageBox.Show("Execute query failed !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseConnection();

            }
            catch(Exception)
            {
                MessageBox.Show("Execute query failed !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseConnection();
            }
            return dt;
        }

        public void UpdateData(string query, string status)
        {
            try
            { 

                OpenConection();
                SqlCommand cmd = new SqlCommand(query, con);
                
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                CloseConnection();
                if(status != "")
                    MessageBox.Show(status);
                else
                    MessageBox.Show("Record inserted successfully");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }
        public void UpdateData(string query)
        {
            try
            {

                OpenConection();
                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                CloseConnection();
                MessageBox.Show("Record inserted successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }
    }
}
