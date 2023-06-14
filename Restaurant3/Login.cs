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

            SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(*) FROM Users WHERE UserName='" + txtUser.Text + "' and Password='" + txtPassword.Text + "'", Constanst.ConnectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1" && GetSelectedUserType(txtUser.Text) == "1")
            {
                MessageBox.Show("خوش آمدید");
                MenuForm menuForm = new MenuForm();
                menuForm.ShowDialog();
            }
            else if (dt.Rows[0][0].ToString() == "1" && GetSelectedUserType(txtUser.Text) == "2")
            {
                MessageBox.Show("خوش آمدید");
                RestaurantForm restaurantForm = new RestaurantForm();
                restaurantForm.ShowDialog();
            }
            else
            {

                MessageBox.Show(".نام کاربری یا پسورد اشتباه است");
            }
        }
        private string GetSelectedUserType(string userName)
        {
            string userType = string.Empty;

            string query = "SELECT Type FROM [Users] WHERE UserName = @UserName";

            using (SqlConnection connection = new SqlConnection(Constanst.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", userName);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userType = reader["Type"].ToString();
                        }
                    }
                }
            }

            return userType;
        }
    }
}
