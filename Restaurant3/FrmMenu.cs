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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        private void GetAll()
        {
       
            SqlConnection con = new SqlConnection(Constanst.ConnectionString);
            con.Open();
            var query = "select * from Foods";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataReader read = com.ExecuteReader();
            if (read.HasRows)
            {
                foodDataGridView.DataSource = read;
            }
            con.Close();
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {

            
        }

        private void saveButton_Click(object sender, EventArgs e)
        { 
            //SqlConnection con = new SqlConnection(Constanst.ConnectionString);
            //con.Open();
            //var query = $"INSERT INTO Foods (RestaurantId,FoodName,Price,Description) VALUES ('4', '{foodNameTextBox.Text}', '{priceTextBox.Text}', '{descriptionTextBox.Text}')";
            //SqlCommand com = new SqlCommand(query, con);
            //com.ExecuteNonQuery();
            //con.Close();
            //var s = new RestaurantService();
            //var a = new SaveRestuarentDto();
            ////s.save(a);

        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void foodNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void foodDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
