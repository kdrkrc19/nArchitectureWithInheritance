using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DbConnection
    {
        public SqlConnection OpenConnection()
        {
            SqlConnection sqlConnection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=NArchWInheritance;Trusted_Connection=True;");
            sqlConnection.Open();
            return sqlConnection;
        }

        public SqlCommand CreateCommand(string query)
        {
            SqlCommand sqlCommand = new SqlCommand(query,OpenConnection());
            return sqlCommand;
        }
    }
}
