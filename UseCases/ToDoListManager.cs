using Entities;

namespace UseCases;

public class ToDoListManager(IToDoItemRepository repository)
{
    private readonly IToDoItemRepository _repository = repository;
    
    public IEnumerable<TodoItem> GetTodoItems()
    {
        return _repository.GetTodoItems();
    }
    
    public void AddTodoItem(TodoItem item)
    {
        _repository.Add(item);
    }
    
    public void MarkItemAsComplete(int id)
    {
        var item = _repository.SearchTodoItems(id);
        item.IsComplete = true;
        _repository.UpDateTodoItem(item);
    }
}