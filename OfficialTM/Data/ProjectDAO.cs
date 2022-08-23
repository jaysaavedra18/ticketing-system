using OfficialTM.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OfficialTM.Data
{
    public class ProjectDAO
    {

        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TicketsDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        // perform all operations on the database. get all, create, delete, get one, search, etc.

        public List<ProjectModel> FetchAll()
        {
            List<ProjectModel> returnList = new List<ProjectModel>();

            // access the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "SELECT * from dbo.projects";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // create a new project object. add to list to return.
                        ProjectModel project = new ProjectModel();
                        project.Id = reader.GetInt32(0);
                        project.Name = reader.GetString(1);
                        project.Description = reader.GetString(2);

                        returnList.Add(project);

                    }
                }

            }


            return returnList;
        }

        public ProjectModel FetchOne(int Id)
        {

            // access the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "SELECT * from dbo.projects WHERE Id = @Id";

                // associate @id with Id parameter

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = Id;



                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                ProjectModel project = new ProjectModel();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // create a new project object and return
                        project.Id = reader.GetInt32(0);
                        project.Name = reader.GetString(1);
                        project.Description = reader.GetString(2);
                        
                    }
                }
                return project;
            }


        }

        // create new 
        // TODO: add validation to form
        // TODO: add date created / date updated
        public int CreateOrUpdate(ProjectModel projectModel)
        {

            // access the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "";

                if (projectModel.Id <= 0)
                {
                    sqlQuery = "INSERT INTO dbo.projects Values(@Name, @Description)";
                }
                else
                {
                    sqlQuery = "UPDATE dbo.projects SET Name = @Name, Description = @Description WHERE Id = @Id";
                }

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add("@Id", System.Data.SqlDbType.Int, 2).Value = projectModel.Id;
                command.Parameters.Add("@Name", System.Data.SqlDbType.VarChar, 50).Value = projectModel.Name;
                command.Parameters.Add("@Description", System.Data.SqlDbType.VarChar, 200).Value = projectModel.Description;
                

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

                string sqlQuery = sqlQuery = "DELETE FROM dbo.projects WHERE Id = @Id";


                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add("@Id", System.Data.SqlDbType.Int, 2).Value = id;

                connection.Open();

                int deletedId = command.ExecuteNonQuery();


                return deletedId;

            }
        }

        internal List<ProjectModel> SearchForName(string searchPhrase)
        {
            List<ProjectModel> returnList = new List<ProjectModel>();

            // access the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "SELECT * from dbo.projects WHERE NAME LIKE @searchForMe";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add("@searchForMe", System.Data.SqlDbType.NVarChar).Value = "%" + searchPhrase + "%";

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // create a new project object. add to list to return.
                        ProjectModel project = new ProjectModel();
                        project.Id = reader.GetInt32(0);
                        project.Name = reader.GetString(1);
                        project.Description = reader.GetString(2);
                        

                        returnList.Add(project);

                    }
                }

            }

            return returnList;
        }

        internal List<ProjectModel> SearchForDescription(string searchPhrase)
        {
            List<ProjectModel> returnList = new List<ProjectModel>();

            // access the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "SELECT * from dbo.projects WHERE DESCRIPTION LIKE @searchForMe";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add("@searchForMe", System.Data.SqlDbType.NVarChar).Value = "%" + searchPhrase + "%";

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // create a new project object. add to list to return.
                        ProjectModel project = new ProjectModel();
                        project.Id = reader.GetInt32(0);
                        project.Name = reader.GetString(1);
                        project.Description = reader.GetString(2);
                        

                        returnList.Add(project);

                    }
                }

            }

            return returnList;
        }
    }
}