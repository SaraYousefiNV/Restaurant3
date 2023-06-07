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
using System.Data.SqlClient;


namespace RestaurantFinal
{
    public partial class FrmLoginCustomers : Form
    {
        SqlConnection sqlcon = new SqlConnection("Data Source=.;Initial Catalog=RestaurantDBtest1;Integrated Security=True");
        public FrmLoginCustomers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from Customers where NatinalCode = '"+txtId.Text+"' AND Mobile = '"+txtId.Text+"'", sqlcon);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("ورود با موفقیت انجام شد");
        }
    }
}
