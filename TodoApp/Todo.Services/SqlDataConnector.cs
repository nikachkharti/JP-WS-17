using Microsoft.Data.SqlClient;
using Todo.Services.Interfaces;
using TodoApp.Library;
using System.Data;

namespace Todo.Services
{
    public class SqlDataConnector : IDataConnection
    {
        public List<TodoApp.Library.Todo> GetAllTodosPerUser(User model)
        {
            const string sqlExpression = "sp_allSpecificUserTodos";
            List<TodoApp.Library.Todo> result = new();

            using (SqlConnection connection = new(GlobalConfig.ConnectionString()))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@userId", model.UserId);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            result.Add(new TodoApp.Library.Todo
                            {
                                TodoId = reader.GetInt32(0),
                                Title = reader.GetString(1),
                                Description = reader.GetString(2),
                                StartDate = reader.GetDateTime(3),
                                DueDate = reader.GetDateTime(4),
                                Status = reader.GetString(5),
                                Priority = reader.GetString(6),
                                UserId = reader.GetInt32(7)
                            });
                        }
                    }
                }
                catch (SqlException)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }

                return result;
            }
        }
        public List<User> GetAllUsers()
        {
            const string sqlExpression = "sp_AllUsers";
            List<User> result = new();

            using (SqlConnection connection = new(GlobalConfig.ConnectionString()))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            result.Add(new User
                            {
                                UserId = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                FullName = reader.GetString(3),
                                Email = reader.GetString(4)
                            });
                        }
                    }
                }
                catch (SqlException)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }

                return result;
            }
        }
        public  User LoginUser(string email)
        {
            const string sqlExpression = "sp_SingleUser";
            User result = new();

            using (SqlConnection connection = new(GlobalConfig.ConnectionString()))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@email", email);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            result.UserId = reader.GetInt32(0);
                            result.FirstName = reader.GetString(1);
                            result.LastName = reader.GetString(2);
                            result.FullName = reader.GetString(3);
                            result.Email = reader.GetString(4); 
                        }
                    }
                }
                catch (SqlException)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }

                return result;
            }

        }
        public User RegisterUser(User model)
        {
            const string sqlExpression = "[dbo].[sp_registerUser]";

            using (SqlConnection connection = new(GlobalConfig.ConnectionString()))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@firstName", model.FirstName);
                    command.Parameters.AddWithValue("@lastName", model.LastName);
                    command.Parameters.AddWithValue("@email", model.Email);

                    command.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }

            return model;
        }
    }
}
