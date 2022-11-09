namespace TodoApp.Tests
{
    public class RegisterUserAsyncShould
    {
        [Fact]
        public async void RegisterNewUserInDatabase()
        {
            SqlDataConnector sqlDataConnector = new();

            var all = await sqlDataConnector.GetAllUsersAsync();

            User userToAdd = new()
            {
                UserId = all.Last().UserId + 1,
                FirstName = "ზურაბ",
                LastName = "ბერიაშვილი",
                FullName = "ზურაბ ბერიაშვილი",
                Email = "ZB@gmail.com",
            };

            Task<User> actual = sqlDataConnector.RegisterUserAsync(userToAdd);

            Assert.Equal(userToAdd, await actual, new UserEquilityComparer());
        }
    }
}
