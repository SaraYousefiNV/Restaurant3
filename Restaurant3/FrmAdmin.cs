using Repository.Repositories;
using Services.Dtos.RestuarentDtos;
using Services.Services;
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
      
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
           
                var connectionstring = "server=.;database=RestaurantDB;trusted_connection=true";
                SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
                var query = "select * from Restaurants";
                SqlCommand SqlCommand = new SqlCommand(query, connection);
                SqlDataReader read = SqlCommand.ExecuteReader();
            //if (read.HasRows)
            //{
            //    foodDataGridView.DataSource = read;
            //}
            
            connection.Close();
            
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var s = new RegisterRestaurant();
            var a = new RegisterRestaurant();
            //s.save(s);
            MessageBox.Show("اطلاعات با موفقیت ثبت شد");
        }
    }
}
