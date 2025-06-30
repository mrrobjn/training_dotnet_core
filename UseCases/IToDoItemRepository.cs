namespace UseCases;
using Entities;

public interface ToDoItemRepository
{
    public IEnumerable<TodoItem> GetTodoItems();
    public void Add(TodoItem item);
    TodoItem SearchTodoItems(int id);
    void UpDateTodoItem(TodoItem item);
}