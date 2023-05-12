using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using audiobook.Models;

namespace audiobook.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
   
   [HttpPost]
   public IActionResult Add(IFormFile mp)
    {    

        Console.WriteLine("In this controller"+mp.FileName);
        return RedirectToAction("Index", "Account");
    }
    
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
