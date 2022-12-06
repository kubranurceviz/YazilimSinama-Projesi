using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace yaz.sın_4
{
    class DBConnection
    {
        public SqlConnection GetMsSqlConnection()
        {
            string connectionString = "Data Source=!!"; //Sql adresi girilecek
            return new SqlConnection(connectionString);
        }
    }
}
