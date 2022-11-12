using TodoApp.Library;

namespace Todo.Services.Interfaces
{
    public interface IDataConnection
    {
        /// <summary>
        /// Get all users.
        /// </summary>
        /// <returns>List of users</returns>
        public List<User> GetAllUsers();

        /// <summary>
        /// Login user in system.
        /// </summary>
        /// <returns>Logged in user</returns>
        public User LoginUser(string email);

        /// <summary>
        /// Registers new user.
        /// </summary>
        /// <param name="model">User model to register</param>
        /// <returns>Registered user.</returns>
        public User RegisterUser(User model);

        /// <summary>
        /// Get all toos for a logged in user.
        /// </summary>
        /// <param name="model">Logged in user</param>
        /// <returns>List of todos</returns>
        public List<TodoApp.Library.Todo> GetAllTodosPerUser(User model);
    }
}
