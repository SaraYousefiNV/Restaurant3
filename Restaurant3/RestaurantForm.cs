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
    public partial class RestaurantForm : Form
    {
        public RestaurantForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            SqlConnection connection = new SqlConnection(Constanst.ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT  [Id],[FullName],[OwnerFullName],[Mobile],[NationalCode],[StartTime],[EndTime],[UserId],[Address] FROM Restaurants";
            da.SelectCommand = cmd;
            da.SelectCommand.Connection = connection;
            da.Fill(dt);
            listBox1.DataSource = dt;
            listBox1.DisplayMember = "FullName";
            listBox1.ValueMember = "FullName";
        }

        private void RestaurantForm_Load(object sender, EventArgs e)
        {
            RestaurantList restaurantList = new RestaurantList();
            
            listBox1.DataSource = restaurantList.SelectAll();
           
        }
    }
}
