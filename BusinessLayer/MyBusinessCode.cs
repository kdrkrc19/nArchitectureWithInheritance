using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbConnection = DataAccessLayer.DbConnection;

namespace BusinessLayer
{
    public class MyBusinessCode
    {
        public List<Users> GetData()
        {
            List<Users> Users = new List<Users>();
            DbConnection dbConnection = new DbConnection();
            SqlConnection sqlConnection = dbConnection.OpenConnection();
            string query = "SELECT * FROM Users";

            SqlCommand sqlCommand = dbConnection.CreateCommand(query);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            while (sqlDataReader.Read())
            {
                Users user = new Users(
                    (int)sqlDataReader["Id"],
                    sqlDataReader["Name"].ToString(),
                    sqlDataReader["Surname"].ToString()
                    );
                Users.Add(user);
            }

            return Users;
        }

        public List<UsersFakeData> ConvertEntityToDTO()
        {
            List<Users> users = GetData();
            List<UsersFakeData> usersFakeDatas = new List<UsersFakeData>();

            foreach (Users item in users)
            {
                UsersFakeData usersFakeData = new UsersFakeData();
                usersFakeData.id = item.id;
                usersFakeData.name = item.name;
                usersFakeData.surname = item.surname;
                usersFakeDatas.Add(usersFakeData);
            }
            return usersFakeDatas;
        }
    }
}
