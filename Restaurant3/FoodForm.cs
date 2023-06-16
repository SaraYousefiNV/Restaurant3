using Repository.Repositories;
using System;
using System.Windows.Forms;

namespace Restaurant3
{
    public partial class FoodForm : Form
    {
        public int resId = 0;
        public FoodForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SelectedRestaurantForm_Load(object sender, EventArgs e)
        {
            RestaurantFoodRepository restaurantFoodRepository = new RestaurantFoodRepository();
            dgFoods.AutoGenerateColumns = false;
            dgFoods.DataSource=restaurantFoodRepository.SelectFoods(resId);
        }
    }
}
