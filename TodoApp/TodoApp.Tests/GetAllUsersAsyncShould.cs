namespace TodoApp.Tests
{
    public class GetAllUsersAsyncShould
    {
        [Fact]
        public async Task Return_All_Users_From_DatabaseAsync()
        {
            SqlDataConnector sqlDataConnector = new();

            List<User> expected = new()
            {
                new User()
                {
                    UserId = 3,
                    FirstName = "ნიკა",
                    LastName = "ჩხარტიშვილი",
                    FullName = "ნიკა ჩხარტიშვილი",
                    Email = "nika.chkhartishvili@gmail.com"
                },
                new User()
                {
                    UserId = 6,
                    FirstName = "ანდრია",
                    LastName = "ჯაფარიძე",
                    FullName = "ანდრია ჯაფარიძე",
                    Email = "andria@gmail.com"
                },
                new User()
                {
                    UserId = 8,
                    FirstName = "ნიკოლოზ",
                    LastName = "ბარათაშვილი",
                    FullName = "ნიკოლოზ ბარათაშვილი",
                    Email = "baratashvili@gmail.com"
                },
                new User()
                {
                    UserId = 9,
                    FirstName = "ლუკა",
                    LastName = "წოწკოლაური",
                    FullName = "ლუკა წოწკოლაური",
                    Email = "luka.wowkolauri123@gmail.com"
                }
            };

            List<User> actual = await sqlDataConnector.GetAllUsersAsync();

            Assert.Equal(expected, actual, new UserEquilityComparer());
        }
    }
}