using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nanatsu_no_Taizai.Data;
using Nanatsu_no_Taizai.Models;
using Nanatsu_no_Taizai.ViewModels;

namespace Nanatsu_no_Taizai.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;

    public HomeController(ILogger<HomeController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        HomeVM home = new()
        {
            Raças = _context.Racas.ToList(),
            Personagems = _context.Personagens
                .Include(p => p.Raca)
                .Include(p => p.Cla)
                .ToList(),
        };
        return View(home);
    }

    public IActionResult Details(int id)
    {
        Personagem personagem = _context.Personagens
                        .Where(p => p.Numero == id)
                        .Include(p => p.Tipos)
                        .ThenInclude(t => t.Tipo)
                        .Include(p => p.Regiao)
                        .Include(p => p.Genero)
                        .SingleOrDefault();

        DetailVM detailVM = new()
        {
            Atual = pokemon,
            Anterior = _context.Pokemons
                .OrderByDescending(p => p.Numero)
                .FirstOrDefault(p => p.Numero < id),
            Proximo = _context.Pokemons
                .OrderBy(p => p.Numero)
                .FirstOrDefault(p => p.Numero > id)
        };

        return View(detailVM);
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