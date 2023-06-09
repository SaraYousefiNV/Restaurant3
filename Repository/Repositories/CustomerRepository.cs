using System.Data;
using System.Data.SqlClient;

namespace Repository.Repositories
{
    public class CustomerRepository
    {
      
        public DataTable SelectAll()
        {
            string query = "SELECT * FROM Customers";
            SqlConnection connection = new SqlConnection(Constanst.ConnectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;

        }

        public bool Insert(string firstname, string lastname, string nationalcode, string mobile, string address, int type)
        {
            var userId = GetLastUserId() + 1;
            SqlConnection connection = new SqlConnection(Constanst.ConnectionString);
            try
            {

                int newID;
                var query = "INSERT INTO Users (UserName,Password,[Type]) VALUES (@UserName,@Password,@Type) ;SELECT CAST(scope_identity() AS int)";
                SqlCommand sqlCommand1 = new SqlCommand(query, connection);

                sqlCommand1.Parameters.AddWithValue("@UserName", nationalcode);
                sqlCommand1.Parameters.AddWithValue("@Password", mobile);
                sqlCommand1.Parameters.AddWithValue("@Type", type);
                connection.Open();
                newID = (int)sqlCommand1.ExecuteScalar();


                string query2 = "INSERT INTO Customers(UserId,FirstName,LastName,NationalCode,Mobile,Address) VALUES (@UserId,@FirstName,@LastName,@NationalCode,@Mobile,@Address)";


                SqlCommand sqlCommand = new SqlCommand(query2, connection);
                sqlCommand.Parameters.AddWithValue("@UserId", newID);
                sqlCommand.Parameters.AddWithValue("@FirstName", firstname);
                sqlCommand.Parameters.AddWithValue("@LastName", lastname);
                sqlCommand.Parameters.AddWithValue("@NationalCode", nationalcode);
                sqlCommand.Parameters.AddWithValue("@Mobile", mobile);
                sqlCommand.Parameters.AddWithValue("@Address", address);
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

        public int GetLastUserId()
        {
            //BozorgTarin UserId ro bargardoone
            return 1;
        }



    }
}
