namespace TodoApp.Library
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public override bool Equals(object obj) => new UserEquilityComparer().Equals(obj);
        public override int GetHashCode() => new UserEquilityComparer().GetHashCode();
    }
}
