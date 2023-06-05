using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuForm().ShowDialog();
        }

        private void factorsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
