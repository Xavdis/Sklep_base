using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Data.SqlClient;

namespace Sklep_base
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

        public void UpdateUserDataForComboBox()
        {
            string Query = "SELECT ID, EmpName FROM EmployeeTbl";

            var items = new List<dynamic>();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    items.Add(new { ID = reader["ID"], Name = reader["EmpName"].ToString() });
                }
            }
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
