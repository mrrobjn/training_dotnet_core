namespace Entities;

public class TodoItem
{
    public int Id { get; set; }
    public required string Title { get; set; } = string.Empty;
    public bool IsComplete { get; set; }
}