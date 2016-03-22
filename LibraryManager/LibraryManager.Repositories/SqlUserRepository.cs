using System.Data;
using System.Data.SqlClient;
using LibraryManager.Entities;
using System;

namespace LibraryManager.Repositories
{
    public class SqlUserRepository : IUserRepository
    {
        private const string spGetUserByLoginQuery = "spGetUserByLogin";
        private readonly string _connectionString;

        public SqlUserRepository(string conncetionString)
        {
            _connectionString = conncetionString;
        }

        public User GetUserByLogin(string login, string password)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spGetUserByLoginQuery;
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        User user = null;

                        if(reader.Read())
                        {
                            user = new User();
                            user.Id = (int)reader["Id"];
                            user.Login = (string)reader["Login"];                            
                            user.IsDisabled = (bool)reader["Disabled"];
                            user.FirstName = (string)reader["FirstName"];
                            user.SecondName = (string)reader["SecondName"];
                        }

                        return user;
                    }
                }
            }                                       
        }
        public User GetUserById(int Id)
        {
            if(Id == 0)
            {
                throw new Exception("Wrong user Id");
            }

            string UserQuery = String.Format("SELECT * FROM [dbo].[tblUser] WHERE Id = {0} AND [Disabled] <> 1", Id);

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = UserQuery;                    

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        User user = null;

                        if (reader.Read())
                        {
                            user = new User();
                            user.Id = (int)reader["Id"];
                            user.Login = (string)reader["Login"];
                            user.IsDisabled = (bool)reader["Disabled"];
                            user.FirstName = (string)reader["FirstName"];
                            user.SecondName = (string)reader["SecondName"];
                        }

                        return user;
                    }
                }
            }
        }
    }
}
