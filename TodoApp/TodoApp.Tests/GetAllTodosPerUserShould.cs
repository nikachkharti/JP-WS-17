namespace TodoApp.Tests
{
    public class GetAllTodosPerUserShould
    {
        SqlDataConnector sqlDataConnector = new();

        [Fact]
        public async Task GetAllTodosForGivenUserAsync()
        {
            User userToTest = new User()
        {
            UserId = 3,
            FirstName = "ნიკა",
            LastName = "ჩხარტიშვილი",
            FullName = "ნიკა ჩხარტიშვილი",
            Email = "nika.chkhartishvili@gmail.com"
        };

            List<Library.Todo> expected = new()
            {
                new()
                {
                    TodoId = 26,
                    Title = "ჩავატარო ლექცია",
                    Description = "ჩავატარო ლექცია winforms -ის შესახებ",
                    StartDate = DateTime.Parse("2022-11-03 19:22:18.100"),
                    DueDate = DateTime.Parse("2022-11-03 19:22:18.100"),
                    Status = "შესასრულებელი",
                    Priority = "მაღალი",
                    UserId = 3
                },
                new()
                {
                    TodoId = 28,
                    Title = "დავასრულო პროექტი",
                    Description = "დავასრულო Front-ის პროექტი სამსახურში",
                    StartDate = DateTime.Parse("2022-11-03 19:23:11.453"),
                    DueDate = DateTime.Parse("2022-11-03 19:23:11.453"),
                    Status = "შესასრულებელი",
                    Priority = "საშუალო",
                    UserId = 3
                }
            };

            List<Library.Todo> actual = await sqlDataConnector.GetAllTodosPerUserAsync(userToTest);

            Assert.Equal(expected, actual, new TodoEquilityComparer());
        }



    }
}
