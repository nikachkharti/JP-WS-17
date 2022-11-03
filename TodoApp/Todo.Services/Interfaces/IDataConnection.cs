using TodoApp.Library;

namespace Todo.Services.Interfaces
{
    public interface IDataConnection
    {
        public Task<List<User>> GetAllUsersAsync();
    }
}
