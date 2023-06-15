using System.Data;
using System.Data.SqlClient;

namespace Repository.Repositories
{
    public class RestaurantList
    {
        public DataTable SelectAll()
        {
            string query = "SELECT  [Id],[FullName],[OwnerFullName],[Mobile],[NationalCode],[StartTime],[EndTime],[UserId],[Address] FROM Restaurants";
            SqlConnection connection1 = new SqlConnection(Constanst.ConnectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection1);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
            
        }

    }
}
