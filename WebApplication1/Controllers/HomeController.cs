using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IRepository repository;

    public HomeController(IRepository repository, ILogger<HomeController> logger)
    {
        this.repository = repository;
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View(new MyTask() { Name = "adbc"});
    }

    public IActionResult Privacy()
    {
        return View("Index", new MyTask() { Name = "adbc" });
    }
    
    public IActionResult Tasks(string name = null)
    {
        _logger.LogInformation($"Name: {name}");
        return Content("Tasks " + repository.getById(name));
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}