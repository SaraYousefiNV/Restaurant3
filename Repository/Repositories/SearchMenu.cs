using System.Data;
using System.Data.SqlClient;

namespace Repository.Repositories
{
    public class SearchMenu
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

        public bool search()
        {

            SqlConnection connection = new SqlConnection(Constanst.ConnectionString);
            try
            {

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
