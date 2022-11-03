using System.Diagnostics.CodeAnalysis;

namespace TodoApp.Library
{
    public class UserEquilityComparer : IEqualityComparer<User>
    {
        public bool Equals(User x, User y) => x.FullName == y.FullName && x.Email == y.Email;
        public int GetHashCode([DisallowNull] User obj) => obj.FullName.Length;
    }
}
