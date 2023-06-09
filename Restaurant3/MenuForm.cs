using Repository.Repositories;
using System;
using System.Windows.Forms;

namespace Restaurant3
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
       
        private void MenuForm_Load(object sender, EventArgs e)
        {
            RepositoryMenu repositoryMenu = new RepositoryMenu();
            foodDataGridView.AutoGenerateColumns = false;
            foodDataGridView.DataSource = repositoryMenu.SelectAll();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            RepositoryMenu RepositoryMenu = new RepositoryMenu();

            bool isSuccess = RepositoryMenu.Insert(txtfoodName.Text,Convert.ToDouble(txtPrice),txtDescription.Text);

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
