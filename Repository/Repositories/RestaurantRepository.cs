using Repository.DataModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class RestaurantRepository
    {
        public void save(Restaurant restuarent)
        {
            SqlConnection con = new SqlConnection(Constanst.ConnectionString);
            con.Open();
            ////var query = $"INSERT INTO Foods (RestaurantId,FoodName,Price,Description) VALUES ('4', '{foodNameTextBox.Text}', '{priceTextBox.Text}', '{descriptionTextBox.Text}')";
            ////SqlCommand com = new SqlCommand(query, con);
            //com.ExecuteNonQuery();
            con.Close();
        }
    }
}
