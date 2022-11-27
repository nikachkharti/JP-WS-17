using TodoApp.Library;

namespace Todo.Services.Interfaces
{
    public interface IDataConnection
    {
        /// <summary>
        /// Get all users.
        /// </summary>
        /// <returns>List of users</returns>
        Task<List<User>> GetAllUsers();

        /// <summary>
        /// Login user in system.
        /// </summary>
        /// <returns>Logged in user</returns>
        Task<User> LoginUser(string email);

        /// <summary>
        /// Registers new user.
        /// </summary>
        /// <param name="model">User model to register</param>
        /// <returns>Registered user.</returns>
        Task<User> RegisterUser(User model);

        /// <summary>
        /// Get all toos for a logged in user.
        /// </summary>
        /// <param name="model">Logged in user</param>
        /// <returns>List of todos</returns>
        Task<List<TodoApp.Library.Todo>> GetAllTodosPerUser(User model);

        /// <summary>
        /// Edits todo in database
        /// </summary>
        /// <param name="model">Todo to edit</param>
        /// <returns>Edited todo</returns>
        Task<TodoApp.Library.Todo> EditTodo(TodoApp.Library.Todo model);

        /// <summary>
        /// Adds todo in database
        /// </summary>
        /// <param name="model">Todo model</param>
        /// <returns>Todo model</returns>
        Task<TodoApp.Library.Todo> AddTodo(TodoApp.Library.Todo model);

        /// <summary>
        /// Deletes todo from database
        /// </summary>
        /// <param name="model">Todo to delete</param>
        /// <returns>Todo model</returns>
        Task<TodoApp.Library.Todo> DeleteTodo(TodoApp.Library.Todo model);
    }
}
