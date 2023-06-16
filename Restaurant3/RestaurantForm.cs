using Repository.Repositories;
using System;
using System.Windows.Forms;

namespace Restaurant3
{
    public partial class RestaurantForm : Form
    {
       
        public RestaurantForm()
        {
            InitializeComponent();
        }

 
        private void RestaurantForm_Load(object sender, EventArgs e)
        {

            RestaurantRepository restaurantRepository = new RestaurantRepository();
            dgResList.AutoGenerateColumns = false;
            dgResList.DataSource = restaurantRepository.SelectAll();
            
        }

        private void dgResList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int resId = int.Parse(dgResList.CurrentRow.Cells[0].Value.ToString());
            FoodForm selectedRestaurantForm = new FoodForm();
            selectedRestaurantForm.resId= resId;
            selectedRestaurantForm.ShowDialog();
                      
          
          
        }

        private void dgResList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
