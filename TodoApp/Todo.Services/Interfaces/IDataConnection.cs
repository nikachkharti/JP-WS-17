using TodoApp.Library;

namespace Todo.Services.Interfaces
{
    public interface IDataConnection
    {
        public Task<List<User>> GetAllUsersAsync();

        //TODO - დაწერეთ ფუნქცია რომელიც User-ების მსგავსად ბაზიდან წამოიღებს ყველა Todo-ს.
    }
}
