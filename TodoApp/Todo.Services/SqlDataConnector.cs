using Microsoft.Data.SqlClient;
using Todo.Services.Interfaces;
using TodoApp.Library;
using System.Data;

namespace Todo.Services
{
    public class SqlDataConnector : IDataConnection
    {
        public async Task<List<TodoApp.Library.Todo>> GetAllTodosPerUserAsync(User model)
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
        public async Task<List<User>> GetAllUsersAsync()
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

        public async Task<User> LoginUserAsync(string email)
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
    }
}
