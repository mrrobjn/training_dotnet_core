using Entities;
using UseCases;

namespace Infrastructure;

public class InMemoryTodoItemRepository : IToDoItemRepository
{
    private readonly List<TodoItem> _todoItems;

    public InMemoryTodoItemRepository()
    {
        _todoItems = [];
    }
    
    public void Add(TodoItem item)
    {
        _todoItems.Add(item);
    }
    
    public IEnumerable<TodoItem> GetTodoItems()
    {
        return _todoItems;
    }

    public TodoItem SearchTodoItems(int id)
    {
        return _todoItems.FirstOrDefault(i => i.Id == id);
    }

    public void UpDateTodoItem(TodoItem item)
    {
        var existingItem = SearchTodoItems(item.Id);
        if (existingItem != null)
        {
            existingItem.Title = item.Title;
            existingItem.IsComplete = item.IsComplete;
        }
    }
}