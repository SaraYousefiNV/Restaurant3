using System.Data.SqlClient;
using System.Data;

namespace Repository.Repositories
{
    public class RestaurantFoodRepository : RestaurantRepository
    {

         
        public DataTable SelectFoods(int resId)
        {
                        
            string query = "SELECT * FROM Foods WHERE RestaurantId =" + resId;
            SqlConnection connection = new SqlConnection(Constanst.ConnectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;

        }
    }
}

