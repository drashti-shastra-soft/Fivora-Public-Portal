using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Fivora.Models;

namespace Fivora.Controllers;

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

    public IActionResult Aboutus()
    {
        return View();
    }
    public IActionResult Projects()
    {
        return View();
    }
    public IActionResult Contactus()
    {
        return View();
    }
    public IActionResult Loanservices()
    {
        return View();
    }
    public IActionResult Investment()
    {
        return View();
    }
    public IActionResult Businessopportunities()
    {
        return View();
    }
    public IActionResult Insurance()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
