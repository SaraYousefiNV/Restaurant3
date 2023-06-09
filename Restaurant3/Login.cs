using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Repository.Repositories;
namespace Restaurant3
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from Users where UserName='" + txtUser.Text + "' and Password='" + txtPassword.Text + "'", Constanst.ConnectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("خوش آمدید");

                MenuForm menuForm = new MenuForm();
                menuForm.ShowDialog();
            }
            else
            {

                MessageBox.Show(".نام کاربری یا پسورد اشتباه است");
            }
        }
    }
}
