﻿using System.Data;
using System.Data.SqlClient;

namespace Repository.Repositories
{
    public class RestaurantList
    {
        public DataTable SelectAll()
        {
            string query = "SELECT * FROM Restaurants";
            SqlConnection connection = new SqlConnection(Constanst.ConnectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;

        }

    }
}
