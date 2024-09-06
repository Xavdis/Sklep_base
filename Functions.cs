using System.Data;
using System.Data.SqlClient;

namespace Sklep_base
{
    internal class Functions
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string connStr;


        public Functions()
        {
            connStr = @"Data Source = DESKTOP-9F97L89;Initial Catalog=Employee;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
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
    }
}
