using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using UseCases;

namespace ToDoList.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ToDoListManager _listManager;

    public HomeController(ToDoListManager listManager, ILogger<HomeController> logger)
    {
        _logger = logger;
        _listManager = listManager;
    }

    public IActionResult Index()
    {
        var todoItems = _listManager.GetTodoItems();
        
        return View(new TodoListViewModel() { Items = todoItems.Select(ti => new Item()
        {
            Id = ti.Id,
            Title = ti.Title,
            IsComplete = ti.IsComplete
        }) });
    }

    public IActionResult Create()
    {
        return RedirectToAction("Add");
    }
    
    public IActionResult Add()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}