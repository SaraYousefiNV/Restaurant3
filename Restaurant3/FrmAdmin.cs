using Repository.Repositories;
using System;
using System.Windows.Forms;

namespace Restaurant3
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
      
       
            private void FrmAdmin_Load(object sender, EventArgs e)
        {
            RestaurantRepository restaurantRepository = new RestaurantRepository();
            dgRestaurant.AutoGenerateColumns = false;
            dgRestaurant.DataSource = restaurantRepository.SelectAll();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RestaurantRepository RestaurantRepository = new RestaurantRepository();
          
            bool isSuccess = RestaurantRepository.Insert(txtFullName.Text, txtOwnerName.Text,txtNationalCode.Text, txtMobile.Text,txtAddress.Text,1,Convert.ToInt32(txtDfrom.Text) , Convert.ToInt32(txtDTo.Text));

            if (isSuccess == true)
            {
                MessageBox.Show("عملیات با موفقیت انجام شد", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("عملیات با شکست مواجه شد", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
            
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
