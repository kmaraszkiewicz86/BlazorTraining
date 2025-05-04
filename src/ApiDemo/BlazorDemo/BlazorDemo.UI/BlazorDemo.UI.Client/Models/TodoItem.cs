namespace BlazorDemo.UI.Client.Models
{
    public class TodoItem
    {
        public int Id { get; init; }
        public string Title { get; init; } = string.Empty;
        public bool IsDone { get; init; }
    }
}
