using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class MathController : Controller
{
    public IActionResult Index()
    {
        return View("Index");
    }
    public int Sum(int a, int b)
    {
        return (a + b);
    }
}