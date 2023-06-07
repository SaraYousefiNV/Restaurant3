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
    public partial class FrmCustomers : Form
    {
        SqlConnection sqlcon = new SqlConnection("Data Source=.;Initial Catalog=RestaurantDBtest1;Integrated Security=True");
        public FrmCustomers()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand("insert into Customers values ('"+txtName.Text+"','"+txtFamily.Text+"','"+txtId.Text+"','"+txtPhone.Text+"','"+txtAddress.Text+ "')",sqlcon);
            sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("اطلاعات با موفقیت ثبت شد");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from Customers", sqlcon);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            dataGridView1.DataSource= dt;
        }
    }
}
