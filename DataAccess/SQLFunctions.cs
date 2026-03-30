using Microsoft.Extensions.Configuration;
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
        private readonly string connStr;
        public SQLFunctions()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json"))
                .Build();

            connStr = config.GetConnectionString("DefaultConnection");
        }
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
            string Query = "SELECT password FROM Login_new WHERE username = @username";

            using (localConn = new SqlConnection(connStr))
            {
                using (localCmd = new SqlCommand(Query, localConn))
                {
                    localCmd.Parameters.AddWithValue("@username", username);
                    localConn.Open();
                    var passwordHash = (string)localCmd.ExecuteScalar();
                    
                    if (passwordHash == null)
                        return false;

                    bool isPasswordCorrect = BCrypt.Net.BCrypt.Verify(password, passwordHash);
                    return isPasswordCorrect;
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
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            using (localConn = new SqlConnection(connStr))
            {
                using (localCmd = new SqlCommand(Query, localConn))
                {
                    SqlCommand cmd = new SqlCommand(Query, localConn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", passwordHash);
                    localConn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        #region SQL DataBase Command For Department Page


        #endregion
    }
}