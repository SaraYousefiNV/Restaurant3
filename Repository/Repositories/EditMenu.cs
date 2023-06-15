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
               
                var sqlCommand1 = new SqlCommand();
                sqlCommand1.Connection = connection;
                sqlCommand1.CommandType = CommandType.Text;
                connection.Open();
                sqlCommand1.CommandText = ("Update Foods Set FoodName=@FoodName,Price=@Price,Deceription=@Deceription where Id=@FooodId");
                sqlCommand1.Parameters.AddWithValue("@FoodName", FoodName);
                sqlCommand1.Parameters.AddWithValue("@Price", Price);
                sqlCommand1.Parameters.AddWithValue("@Deceription", Description);
                sqlCommand1.ExecuteNonQuery();
                connection.Close();


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



    


