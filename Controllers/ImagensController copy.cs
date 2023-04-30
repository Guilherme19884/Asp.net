using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using aula20._04.Models;

namespace aula20._04.Controllers;

public class ImagensController : Controller
{
    private readonly ILogger<ImagensController> _logger;

    public ImagensController(ILogger<ImagensController> logger)
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
