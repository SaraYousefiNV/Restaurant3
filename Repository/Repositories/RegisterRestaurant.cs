using Repository.DataModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class RegisterRestaurant
    {
        private object txtName, txtOwnerName, txtNationalCode, txtStartTime, txtEndTime, txtAddress;
        
        public void save(Restaurant restuarent)
        {
            var connectionstring = "server=.;database=RestaurantDB;trusted_connection=true";

            SqlConnection con = new SqlConnection(Constanst.ConnectionString);
            con.Open();
            var query = $"INSERT INTO Restaurants (Name,OwnerFullName,NationalCode,StartTime,EndTime,Address) VALUES ('{txtName}', '{txtOwnerName}', '{txtNationalCode}', '{txtStartTime}', '{txtEndTime}', '{txtAddress}')";
            SqlCommand com = new SqlCommand(query, con);
            com.ExecuteNonQuery();
            con.Close();
        }
    }
    
}
