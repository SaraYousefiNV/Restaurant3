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
using System.Xml.Linq;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace RestaurantFinal
{
    public partial class FrmRestaurantRegister : Form
    {
        SqlConnection sqlcon = new SqlConnection("Data Source=.;Initial Catalog=RestaurantDBtest1;Integrated Security=True");
        public FrmRestaurantRegister()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand("insert into Restaurants values ('" + txtRName.Text + "','" + txtROName.Text + "','" + txtROId.Text + "','" + txtROPhone.Text + "','" + txtStart.Text + "','" + txtEnd.Text + "','" + txtAddress.Text + "')", sqlcon);
            sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("اطلاعات رستوران شما با موفقیت ثبت شد");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from Restaurants", sqlcon);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
