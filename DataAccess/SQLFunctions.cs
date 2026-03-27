using System.Data;
using System.Data.SqlClient;

namespace Sklep_base.DataAccess
{
    internal class SQLFunctions
    {
        private SqlConnection localConn;
        private SqlCommand localCmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string connStr = $"Data Source=100.105.83.111;Initial Catalog=EmployeeDataBase; Persist Security Info=True;User ID=sa;Password=admin!23;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;";

        public string ConnStr => connStr;


        public DataTable GetData(string Query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Query, connStr);
            sda.Fill(dt);
            return dt;
        }

        public int SetData(string Query)
        {
            using (localConn = new SqlConnection(connStr))
            {
                using (localCmd = new SqlCommand(Query, localConn))
                {
                    int cnt = 0;
                    if (localConn.State == ConnectionState.Closed)
                    {
                        localConn.Open();
                    }
                    localCmd.CommandText = Query;
                    cnt = localCmd.ExecuteNonQuery();
                    return cnt;
                }
            }
        }

        public bool ValidateUser(string username, string password)
        {
            string Query = "SELECT COUNT(*) FROM Login_new WHERE username = @username AND password = @password";
            using (localConn = new SqlConnection(connStr))
            {
                using (localCmd = new SqlCommand(Query, localConn))
                {
                    localCmd.Parameters.AddWithValue("@username", username);
                    localCmd.Parameters.AddWithValue("@password", password);
                    localConn.Open();
                    int count;
                    count = (int)localCmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public bool IsUserExists(string username)
        {
            string Query = "SELECT COUNT(*) FROM Login_new WHERE username = @username";
            using (localConn = new SqlConnection(connStr))
            {
                using (localCmd = new SqlCommand(Query, localConn))
                {
                    SqlCommand cmd = new SqlCommand(Query, localConn);
                    cmd.Parameters.AddWithValue("@username", username);
                    int count;
                    localConn.Open();
                    count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                        return true;
                    else
                        return false;
                }
            }
        }

        public void CreateUser(string username, string password)
        {
            string Query = "INSERT INTO Login_new (username, password) VALUES (@username, @password)";
            using (localConn = new SqlConnection(connStr))
            {
                using (localCmd = new SqlCommand(Query, localConn))
                {
                    SqlCommand cmd = new SqlCommand(Query, localConn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    localConn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        #region SQL DataBase Command For Department Page
        

        #endregion
    }
}