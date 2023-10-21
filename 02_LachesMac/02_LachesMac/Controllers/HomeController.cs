using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _02_LachesMac.Models;

namespace _02_LachesMac.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

