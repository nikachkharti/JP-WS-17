using TodoApp.Library;

namespace Todo.Services.Interfaces
{
    public interface IDataConnection
    {
        /// <summary>
        /// Get all users.
        /// </summary>
        /// <returns>List of users</returns>
        public Task<List<User>> GetAllUsersAsync();

        /// <summary>
        /// Login user in system.
        /// </summary>
        /// <returns>Logged in user</returns>
        public Task<User> LoginUserAsync(string email);

        /// <summary>
        /// Get all toos for a logged in user.
        /// </summary>
        /// <param name="model">Logged in user</param>
        /// <returns>List of todos</returns>
        public Task<List<TodoApp.Library.Todo>> GetAllTodosPerUserAsync(User model);


        //TODO -- User Login Functioality has to be added
        //TODO -- User Registration Functioality has to be added
    }
}
