using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using aula20._04.Models;

namespace aula20._04.Controllers;

public class QuemSomosController : Controller
{
    private readonly ILogger<QuemSomosController> _logger;

    public QuemSomosController(ILogger<QuemSomosController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
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
