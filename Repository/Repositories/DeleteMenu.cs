using System.Data;
using System.Data.SqlClient;

namespace Repository.Repositories
{
    public class DeleteMenu
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

        public bool delete()
        {

            SqlConnection connection = new SqlConnection(Constanst.ConnectionString);
            try
            {
                connection.Open();
                var query = "delete  from  Foods  where id=@FoodId ";
                SqlCommand sqlCommand1 = new SqlCommand(query, connection);
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
