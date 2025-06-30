using Entities;
using Infrastructure;
using UseCases;
using Xunit;

namespace TestProject
{
    public class UnitTest1
    {
        [TestFixture]
        public void CreateTodoItem_And_Set_Completed_Test()
        {
            // Arrange
            var mockRepository = new InMemoryTodoItemRepository();
            var todoListManager = new ToDoListManager(mockRepository);

            var todoItem = new TodoItem { Id = 1, Title = "Test Item", IsComplete = false };

            // Act
            todoListManager.AddTodoItem(todoItem);
            todoListManager.MarkItemAsComplete(1);

            // Assert
            Assert.True(todoListManager.GetTodoItems().First().IsComplete);
            Assert.Equal("Test Item", todoListManager.GetTodoItems().First().Title);
        }
    }
}