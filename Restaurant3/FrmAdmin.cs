using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant3
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        private void GetAll()
        {
            SqlConnection con = new SqlConnection(Constanst.ConnectionString);
            con.Open();
            var query = $"Select * from Restaurants";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataReader read = com.ExecuteReader();

            if (read.HasRows)
            {
                DataTable dt = new DataTable();
                dataGridView1.DataSource = read;
            }
            con.Close();
        }
            private void FrmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constanst.ConnectionString);
            con.Open();
            var query = $"INSERT INTO Restaurants (Name,OwnerFullName,NationalCode,StartTime,EndTime,Address) VALUES (N'{txtName.Text}', N'{txtOwnerName.Text}', N'{txtDateTo.Text}', N'{txtDatefrom.Text}', N'{txtMobile.Text}',N'{txtNationalCode.Text}', N'{txtAddress.Text}')";
            SqlCommand com = new SqlCommand(query, con);
            com.ExecuteNonQuery();
            con.Close();
            GetAll();
        }
    }
}
