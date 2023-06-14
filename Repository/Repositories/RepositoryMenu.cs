using System;
using System.Data;
using System.Data.SqlClient;

namespace Repository.Repositories
{
    public class RepositoryMenu
    {

        public DataTable SelectAll()
        {
            string query = "SELECT FoodName As N'نام',Price As N'قیمت',Description as N'توضیحات' FROM Foods";
            SqlConnection connection = new SqlConnection(Constanst.ConnectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;

        }
      
        public bool Insert( string FoodName, double Price, string Description)
        {
         
            SqlConnection connection = new SqlConnection(Constanst.ConnectionString);
            try
            {
                int newID;
                var query = "(SELECT id From Restaurants )";
                SqlCommand sqlCommand1 = new SqlCommand(query, connection);

                connection.Open();
                newID = (int)sqlCommand1.ExecuteScalar();
                string query2 = "INSERT INTO Foods(RestaurantId,FoodName,Price,Description) VALUES (@RestaurantId,@FoodName,@Price,@Description)";


                SqlCommand sqlCommand = new SqlCommand(query2, connection);
                sqlCommand.Parameters.AddWithValue("@RestaurantId", newID);
                sqlCommand.Parameters.AddWithValue("@FoodName", FoodName);
                sqlCommand.Parameters.AddWithValue("@Price", Price);
                sqlCommand.Parameters.AddWithValue("@Description", Description); 
                sqlCommand.ExecuteNonQuery();


                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            
        }
       
        
        

    }
}

