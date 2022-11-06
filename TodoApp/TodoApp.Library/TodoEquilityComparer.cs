using System.Diagnostics.CodeAnalysis;

namespace TodoApp.Library
{
    public class TodoEquilityComparer : IEqualityComparer<Todo>
    {
        public bool Equals(Todo x, Todo y) => x.Title == y.Title && x.Description == y.Description;
        public int GetHashCode([DisallowNull] Todo obj) => obj.Title.Length + obj.Description.Length;
    }
}
