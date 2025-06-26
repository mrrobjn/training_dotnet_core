using Entities;

namespace UseCases;

public class ToDoListManager(ToDoItemRepository repository)
{
    private readonly ToDoItemRepository _repository = repository;
    
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
        var item = _repository.searchTodoItems(id);
        item.IsComplete = true;
        _repository.UpDateTodoItem(item);
    }
}