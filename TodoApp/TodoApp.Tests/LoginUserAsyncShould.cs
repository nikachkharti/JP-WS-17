namespace TodoApp.Tests
{
    public class LoginUserAsyncShould
    {
        [Fact]
        public async void ReturnSingleUser()
        {
            SqlDataConnector sqlDataConnector = new();

            string argument = "baratashvili@gmail.com";

            User expected = new()
            {
                UserId = 8,
                FirstName = "ნიკოლოზ",
                LastName = "ბარათაშვილი",
                FullName = "ნიკოლოზ ბარათაშვილი",
                Email = "baratashvili@gmail.com"
            };

            User actual = await sqlDataConnector.LoginUserAsync(argument);

            Assert.Equal(expected, actual, new UserEquilityComparer());
        }
    }
}
