using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RestaurantFinal
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLoginCustomers newLogin = new FrmLoginCustomers();
            newLogin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCustomers newCustomer = new FrmCustomers();
            newCustomer.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmRestaurantRegister newRestaurant = new FrmRestaurantRegister();
            newRestaurant.Show();
        }
    }
}
