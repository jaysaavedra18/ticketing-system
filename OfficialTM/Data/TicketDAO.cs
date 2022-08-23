using OfficialTM.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace OfficialTM.Data
{
    internal class TicketDAO
    {

        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TicketsDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        // perform all operations on the database. get all, create, delete, get one, search, etc.

        public List<TicketModel> FetchAll()
        {
            List<TicketModel> returnList = new List<TicketModel>();

            // access the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "SELECT * from dbo.Tickets";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // create a new ticket object. add to list to return.
                        TicketModel ticket = new TicketModel();
                        ticket.Id = reader.GetInt32(0);
                        ticket.Title = reader.GetString(1);
                        ticket.Description = reader.GetString(2);
                        ticket.Submitter = reader.GetString(3);
                        ticket.Status = reader.GetString(4);
                        ticket.Priority = reader.GetInt32(5);
                        ticket.Type = reader.GetString(6);

                        returnList.Add(ticket);

                    }
                }

            }


            return returnList;
        }

        public TicketModel FetchOne(int Id)
        {

            // access the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "SELECT * from dbo.Tickets WHERE Id = @Id";

                // associate @id with Id parameter

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = Id;



                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                TicketModel ticket = new TicketModel();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // create a new ticket object. add to list to return.
                        ticket.Id = reader.GetInt32(0);
                        ticket.Title = reader.GetString(1);
                        ticket.Description = reader.GetString(2);
                        ticket.Submitter = reader.GetString(3);
                        ticket.Status = reader.GetString(4);
                        ticket.Priority = reader.GetInt32(5);
                        ticket.Type = reader.GetString(6);

                    }
                }
                return ticket;
            }


        }

        // create new 
        // TODO: add validation to form
        // TODO: add date created / date updated
        public int CreateOrUpdate(TicketModel ticketModel)
        {

            // access the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "";

                if (ticketModel.Id <= 0)
                {
                    sqlQuery = "INSERT INTO dbo.tickets Values(@Title, @Description, @Submitter, @Status, @Priority, @Type)";
                }
                else
                {
                    sqlQuery = "UPDATE dbo.tickets SET Title = @Title, Description = @Description, Submitter = @Submitter, Status = @Status, Priority = @Priority, Type = @Type WHERE Id = @Id";
                }

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add("@Id", System.Data.SqlDbType.Int, 2).Value = ticketModel.Id;
                command.Parameters.Add("@Title", System.Data.SqlDbType.VarChar, 50).Value = ticketModel.Title;
                command.Parameters.Add("@Description", System.Data.SqlDbType.VarChar, 200).Value = ticketModel.Description;
                command.Parameters.Add("@Submitter", System.Data.SqlDbType.VarChar, 50).Value = ticketModel.Submitter;
                command.Parameters.Add("@Status", System.Data.SqlDbType.VarChar, 50).Value = ticketModel.Status;
                command.Parameters.Add("@Priority", System.Data.SqlDbType.Int, 1).Value = ticketModel.Priority;
                command.Parameters.Add("@Type", System.Data.SqlDbType.VarChar, 50).Value = ticketModel.Type;


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

                string sqlQuery = sqlQuery = "DELETE FROM dbo.tickets WHERE Id = @Id";
               

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add("@Id", System.Data.SqlDbType.Int, 2).Value = id;

                connection.Open();

                int deletedId = command.ExecuteNonQuery();


                return deletedId;

            }
        }

        internal List<TicketModel> SearchForTitle(string searchPhrase)
        {
            List<TicketModel> returnList = new List<TicketModel>();

            // access the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "SELECT * from dbo.Tickets WHERE TITLE LIKE @searchForMe";
                
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                
                command.Parameters.Add("@searchForMe", System.Data.SqlDbType.NVarChar).Value = "%" + searchPhrase + "%";

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // create a new ticket object. add to list to return.
                        TicketModel ticket = new TicketModel();
                        ticket.Id = reader.GetInt32(0);
                        ticket.Title = reader.GetString(1);
                        ticket.Description = reader.GetString(2);
                        ticket.Submitter = reader.GetString(3);
                        ticket.Status = reader.GetString(4);
                        ticket.Priority = reader.GetInt32(5);
                        ticket.Type = reader.GetString(6);

                        returnList.Add(ticket);

                    }
                }

            }

            return returnList;
        }

        internal List<TicketModel> SearchForStatus(string searchPhrase)
        {
            List<TicketModel> returnList = new List<TicketModel>();

            // access the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "SELECT * from dbo.Tickets WHERE STATUS LIKE @searchForMe";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add("@searchForMe", System.Data.SqlDbType.NVarChar).Value = "%" + searchPhrase + "%";

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // create a new ticket object. add to list to return.
                        TicketModel ticket = new TicketModel();
                        ticket.Id = reader.GetInt32(0);
                        ticket.Title = reader.GetString(1);
                        ticket.Description = reader.GetString(2);
                        ticket.Submitter = reader.GetString(3);
                        ticket.Status = reader.GetString(4);
                        ticket.Priority = reader.GetInt32(5);
                        ticket.Type = reader.GetString(6);

                        returnList.Add(ticket);

                    }
                }

            }

            return returnList;
        }

        internal List<TicketModel> SearchForSubmitter(string searchPhrase)
        {
            List<TicketModel> returnList = new List<TicketModel>();

            // access the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "SELECT * from dbo.Tickets WHERE SUBMITTER LIKE @searchForMe";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add("@searchForMe", System.Data.SqlDbType.NVarChar).Value = "%" + searchPhrase + "%";

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // create a new ticket object. add to list to return.
                        TicketModel ticket = new TicketModel();
                        ticket.Id = reader.GetInt32(0);
                        ticket.Title = reader.GetString(1);
                        ticket.Description = reader.GetString(2);
                        ticket.Submitter = reader.GetString(3);
                        ticket.Status = reader.GetString(4);
                        ticket.Priority = reader.GetInt32(5);
                        ticket.Type = reader.GetString(6);

                        returnList.Add(ticket);

                    }
                }

            }

            return returnList;
        }

    }
}