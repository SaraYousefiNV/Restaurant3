using System.Data;
using System.Data.SqlClient;

namespace Repository.Repositories
{
    public class EditMenu
    {
        public DataTable SelectAll()
        {
            string query = "SELECT * FROM Foods";
            SqlConnection connection = new SqlConnection(Constanst.ConnectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;

        }

        public bool Edit(string FoodName, double Price, string Description)
        {

            SqlConnection connection = new SqlConnection(Constanst.ConnectionString);
            try
            {
                connection.Open();
                var query = "update Foods set FoodName=@FoodName,Price=@Price,Description=@Description where Id=@FoodId ";
                SqlCommand sqlCommand1 = new SqlCommand(query, connection);

                sqlCommand1.Parameters.AddWithValue("@FoodName", FoodName);
                sqlCommand1.Parameters.AddWithValue("@Price", Price);
                sqlCommand1.Parameters.AddWithValue("@Description", Description);
                sqlCommand1.ExecuteNonQuery();


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



    


