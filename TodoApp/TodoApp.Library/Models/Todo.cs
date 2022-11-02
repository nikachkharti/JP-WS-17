namespace TodoApp.Library.Models
{
    public class Todo
    {
        public int TodoId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public int UserId { get; set; }
    }
}
