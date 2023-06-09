using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;
using System.Runtime.Remoting.Services;
using Repository;
using Repository.Repositories;
using Repository.Enums;

namespace Restaurant3
{
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();
        }



        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFamily_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load_1(object sender, EventArgs e)
        {
            CustomerRepository customerRepository = new CustomerRepository();
            dgUsers.AutoGenerateColumns = false;
            dgUsers.DataSource = customerRepository.SelectAll();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CustomerRepository CustomersRepository = new CustomerRepository();
            bool isSuccess = CustomersRepository.Insert(txtName.Text, txtFamily.Text, txtID.Text, txtAddress.Text, txtAddress.Text, Convert.ToInt32(UserType.users));
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
