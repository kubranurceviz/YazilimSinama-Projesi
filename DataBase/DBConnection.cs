using System.Data.SqlClient;

namespace yaz.sın_4
{
    class DBConnection
    {
        public SqlConnection GetMsSqlConnection()
        {                               
            string connectionString = "Data Source=. ; initial catalog=YazilimSinama; User id = sa; Integrated Security=True";
            return new SqlConnection(connectionString);
        }
    }
}
