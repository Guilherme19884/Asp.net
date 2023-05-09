using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using aula20._04.Models;

namespace aula20._04.Controllers;

public class ContatoController : Controller
{
    private readonly ILogger<ContatoController> _logger;

    public ContatoController(ILogger<ContatoController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Adicionar()
    {
        return Adicionar();
    }

    // [HttpPost]
    // public IActionResult Criar(Contato contato)
    // {
    //     if (ModelState.IsValid)
    //     {
    //         _context.Contatos.Add(contato);
    //         _context.SaveChanges();
    //         return RedirectToAction(nameof(Index));
    //     }
    //     return View(contato);
    // }
    public IActionResult Editar()
    {
        return View();
    }
    public IActionResult ExcluirAposConfirmacao()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
