namespace ToDoList.Models;

public class Item
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public bool IsComplete { get; set; }
}