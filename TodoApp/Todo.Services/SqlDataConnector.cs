using Microsoft.Data.SqlClient;
using Todo.Services.Interfaces;
using TodoApp.Library;
using System.Data;

namespace Todo.Services
{
    public class SqlDataConnector : IDataConnection
    {
        public async Task<TodoApp.Library.Todo> AddTodo(TodoApp.Library.Todo model)
        {
            const string sqlExpression = "sp_insertTodo";

            using (SqlConnection connection = new(GlobalConfig.ConnectionString()))
            {
                try
                {
                    await connection.OpenAsync();
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@title",model.Title);
                    command.Parameters.AddWithValue("@description", model.Description);
                    command.Parameters.AddWithValue("@startDate", model.StartDate);
                    command.Parameters.AddWithValue("@dueDate", model.DueDate);
                    command.Parameters.AddWithValue("@status", model.Status);
                    command.Parameters.AddWithValue("@priority", model.Priority);
                    command.Parameters.AddWithValue("@userId", model.UserId);

                    await command.ExecuteNonQueryAsync();
                }
                catch (SqlException)
                {
                    throw;
                }
                finally
                {
                    await connection.CloseAsync();
                }
            }

            return model;
        }

        public async Task<TodoApp.Library.Todo> DeleteTodo(TodoApp.Library.Todo model)
        {
            const string sqlExpression = "sp_deleteTodo";

            using (SqlConnection connection = new(GlobalConfig.ConnectionString()))
            {
                try
                {
                    await connection.OpenAsync();
                    SqlCommand command = new(sqlExpression,connection);
                    command.CommandType= CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@todoId", model.TodoId);

                    await command.ExecuteNonQueryAsync();
                }
                catch (SqlException)
                {
                    throw;
                }
                finally
                {
                    await connection.CloseAsync();
                }
            }

            return model;
        }

        public async Task<TodoApp.Library.Todo> EditTodo(TodoApp.Library.Todo model)
        {
            const string sqlExpression = "sp_editTodo";

            using (SqlConnection connection = new(GlobalConfig.ConnectionString()))
            {
                try
                {
                    await connection.OpenAsync();
                    SqlCommand command = new(sqlExpression,connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@title",model.Title);
                    command.Parameters.AddWithValue("@description", model.Description);
                    command.Parameters.AddWithValue("@startDate", model.StartDate);
                    command.Parameters.AddWithValue("@dueDate", model.DueDate);
                    command.Parameters.AddWithValue("@status", model.Status);
                    command.Parameters.AddWithValue("@priority", model.Priority);
                    command.Parameters.AddWithValue("@todoId", model.TodoId);

                    await command.ExecuteNonQueryAsync();

                }
                catch (SqlException)
                {
                    throw;
                }
                finally
                {
                    await connection.CloseAsync();
                }
            }

            return model;
        }
        public async Task<User> EditUser(User model)
        {
            const string sqlExpression = "sp_editUser";

            using (SqlConnection connection = new(GlobalConfig.ConnectionString()))
            {
                try
                {
                    await connection.OpenAsync();
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@firstName",model.FirstName);
                    command.Parameters.AddWithValue("@lastName",model.LastName);
                    command.Parameters.AddWithValue("@email", model.Email);
                    command.Parameters.AddWithValue("@userId", model.UserId);

                    await command.ExecuteNonQueryAsync();
                }
                catch (SqlException)
                {
                    throw;
                }
                finally
                {
                    await connection.CloseAsync();
                }
            }

            return model;
        }
        public async Task<List<TodoApp.Library.Todo>> GetAllTodosPerUser(User model)
        {
            const string sqlExpression = "sp_allSpecificUserTodos";
            List<TodoApp.Library.Todo> result = new();

            using (SqlConnection connection = new(GlobalConfig.ConnectionString()))
            {
                try
                {
                    await connection.OpenAsync();

                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@userId", model.UserId);

                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
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
                    await connection.CloseAsync();
                }

                return result;
            }
        }
        public async Task<List<User>> GetAllUsers()
        {
            const string sqlExpression = "sp_AllUsers";
            List<User> result = new();

            using (SqlConnection connection = new(GlobalConfig.ConnectionString()))
            {
                try
                {
                    await connection.OpenAsync();
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
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
                    await connection.CloseAsync();
                }

                return result;
            }
        }

        public async Task<User> GetUser(User model)
        {
            const string sqlExpression = "sp_getSingleUser";
            User result = new();

            using (SqlConnection connection = new(GlobalConfig.ConnectionString()))
            {
                try
                {
                    await connection.OpenAsync();
                    SqlCommand command = new(sqlExpression,connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue(@"userId", model.UserId);

                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            result.UserId = reader.GetInt32(0);
                            result.FirstName = reader.GetString(1);
                            result.LastName = reader.GetString(2);
                            result.FullName = reader.GetString(3);
                            result.Email = reader.GetString(4);
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    await connection.CloseAsync();
                }

                return result;
            }
        }

        public async Task<User> LoginUser(string email)
        {
            const string sqlExpression = "sp_SingleUser";
            User result = new();

            using (SqlConnection connection = new(GlobalConfig.ConnectionString()))
            {
                try
                {
                    await connection.OpenAsync();
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@email", email);

                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
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
                    await connection.CloseAsync();
                }

                return result;
            }

        }
        public async Task<User> RegisterUser(User model)
        {
            const string sqlExpression = "[dbo].[sp_registerUser]";

            using (SqlConnection connection = new(GlobalConfig.ConnectionString()))
            {
                try
                {
                    await connection.OpenAsync();
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@firstName", model.FirstName);
                    command.Parameters.AddWithValue("@lastName", model.LastName);
                    command.Parameters.AddWithValue("@email", model.Email);

                    await command.ExecuteNonQueryAsync();
                }
                catch (SqlException)
                {
                    throw;
                }
                finally
                {
                    await connection.CloseAsync();
                }
            }

            return model;
        }
    }
}
