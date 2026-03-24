using System.Data;
using System.Data.SqlClient;

namespace Sklep_base.DataAccess
{
    internal class SQLFunctions
    {

        private SqlConnection conn;
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string connStr = $"Data Source=100.105.83.111;Initial Catalog=EmployeeDataBase; Persist Security Info=True;User ID=sa;Password=admin!23;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;";

        public string ConnStr
        {
            get { return connStr; }
        }

        public SQLFunctions()
        {
            conn = new SqlConnection(connStr);
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        public DataTable GetData(string Query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Query, connStr);
            sda.Fill(dt);
            return dt;
        }

        public int SetData(string Query)
        {
            int cnt = 0;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            cmd.CommandText = Query;
            cnt = cmd.ExecuteNonQuery();
            return cnt;
        }

        public bool ValidateUser(string username, string password)
        {

            string query = "SELECT COUNT(*) FROM Login_new WHERE username = @username AND password = @password";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            int count;
            using (conn = new SqlConnection(connStr))
            {
                conn.Open();
                count = (int)cmd.ExecuteScalar();
            }
            return count > 0;
        }

        public bool IsUserExists(string username)
        {

            string query = "SELECT COUNT(*) FROM Login_new WHERE username = @username";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            int count;
            using (conn = new SqlConnection(connStr))
            {
                conn.Open();
                count = (int)cmd.ExecuteScalar();
            }
            if (count > 0)
                return true;
            else
                return false;
        }

        public void CreateUser(string username, string password)
        {

            string query = "INSERT INTO Login_new (username, password) VALUES (@username, @password)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            using (conn = new SqlConnection(connStr))
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}