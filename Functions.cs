using Microsoft.VisualBasic.ApplicationServices;
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
        private string connStr = $"Data Source=100.105.83.111;Persist Security Info=True;User ID=sa;Password=admin!23;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;";
        public string ConnStr
        {
            get { return connStr; }
        }
        public Functions()
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

        public void RefreashDataBase(int value)
        {
            string Query;
            string whatBase = value switch
            {
                1 => "DepartmantTbl",
                2 => "EmployeeTbl",
                3 => "SalaryTbl"
            };

            Query = $"SELECT * INTO Temporary{whatBase} FROM {whatBase};"; SetData(Query);
            Query = $"Delete from {whatBase};"; SetData(Query);
            Query = $"DBCC CHECKIDENT ('{whatBase}', RESEED, 0);"; SetData(Query);

            if (value == 1)
            {
                Query = $"INSERT INTO {whatBase} (DepName) " +
                    $"SELECT DepName " +
                    $"FROM Temporary{whatBase};"; SetData(Query);
            }
            else if (value == 2)
            {
                Query = $"INSERT INTO {whatBase} (EmpName,EmpSurname,EmpGender,EmpDepart,EmpBornDate,EmpJoingDate,EmpSalary) " +
                    $"SELECT EmpName,EmpSurname,EmpGender,EmpDepart,EmpBornDate,EmpJoingDate,EmpSalary " +
                    $"FROM Temporary{whatBase};"; SetData(Query);
            }
            else if (value == 3)
            {
                Query = $"INSERT INTO {whatBase} (Employee,Attendance,Period,Amount,PayDate) " +
                    $"SELECT Employee,Attendance,Period,Amount,PayDate " +
                    $"FROM Temporary{whatBase};"; SetData(Query);
            }

            Query = $"DROP TABLE Temporary{whatBase};"; SetData(Query);
        }
    }
}
