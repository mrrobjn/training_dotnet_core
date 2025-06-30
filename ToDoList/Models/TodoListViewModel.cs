using Entities;

namespace ToDoList.Models;

public class TodoItemViewModel
{
    public required IEnumerable<TodoItem> Items { get; init; }
}