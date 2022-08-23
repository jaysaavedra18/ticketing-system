using OfficialTM.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace OfficialTM.Data
{
    public class UserDAO
    {

        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TicketsDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        // perform all operations on the database. get all, create, delete, get one, search, etc.

        public List<UserModel> FetchAll()
        {
            List<UserModel> returnList = new List<UserModel>();

            // access the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "SELECT * from dbo.Users";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // create a new user object. add to list to return.
                        UserModel user = new UserModel();
                        user.Id = reader.GetInt32(0);
                        user.Name = reader.GetString(1);
                        user.Email = reader.GetString(2);
                        user.Role = reader.GetString(3);

                        returnList.Add(user);

                    }
                }

            }


            return returnList;
        }

        public UserModel FetchOne(int Id)
        {

            // access the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "SELECT * from dbo.Users WHERE Id = @Id";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = Id;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                UserModel user = new UserModel();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // create a new user object to return.
                        user.Id = reader.GetInt32(0);
                        user.Name = reader.GetString(1);
                        user.Email = reader.GetString(2);
                        user.Role = reader.GetString(3);

                    }
                }
                return user;
            }



        }

        // create new 
        // TODO: add validation to form
        // TODO: add date created / date updated
        public int CreateOrUpdate(UserModel userModel)
        {

            // access the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "";

                if (userModel.Id <= 0)
                {
                    sqlQuery = "INSERT INTO dbo.users Values(@Name, @Email, @Role)";
                }
                else
                {
                    sqlQuery = "UPDATE dbo.users SET Name = @Name, Email = @Email, Role = @Role WHERE Id = @Id";
                }

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add("@Id", System.Data.SqlDbType.Int, 2).Value = userModel.Id;
                command.Parameters.Add("@Name", System.Data.SqlDbType.VarChar, 50).Value = userModel.Name;
                command.Parameters.Add("@Email", System.Data.SqlDbType.VarChar, 200).Value = userModel.Email;
                command.Parameters.Add("@Role", System.Data.SqlDbType.VarChar, 50).Value = userModel.Role;


                connection.Open();

                int newId = command.ExecuteNonQuery();


                return newId;

            }


        }

        internal int Delete(int id)
        {

            // access the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = sqlQuery = "DELETE FROM dbo.users WHERE Id = @Id";


                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add("@Id", System.Data.SqlDbType.Int, 2).Value = id;

                connection.Open();

                int deletedId = command.ExecuteNonQuery();


                return deletedId;

            }
        }

        internal List<UserModel> SearchForName(string searchPhrase)
        {
            List<UserModel> returnList = new List<UserModel>();

            // access the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "SELECT * from dbo.users WHERE NAME LIKE @searchForMe";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add("@searchForMe", System.Data.SqlDbType.NVarChar).Value = "%" + searchPhrase + "%";

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // create a new user object. add to list to return.
                        UserModel user = new UserModel();
                        user.Id = reader.GetInt32(0);
                        user.Name = reader.GetString(1);
                        user.Email = reader.GetString(2);
                        user.Role = reader.GetString(3);

                        returnList.Add(user);
                    }
                }

            }

            return returnList;
        }

    }
}