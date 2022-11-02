using TodoApp.Library.Models;

namespace TodoApp.Library.Interfaces
{
    public interface IDataConnection
    {
        public List<User> GetAllUsers();
    }
}
