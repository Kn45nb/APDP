using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using test2.DATA;
using test2.Models;

namespace test2.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ApplicationDbContext context, ILogger<HomeController> logger)
    {
        _context = context;
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Submit(InputData inputData)
    {
        if (ModelState.IsValid)
        {
            _context.Add(inputData);
            await _context.SaveChangesAsync();
            ViewBag.Message = "Data submitted successfully!";
            return RedirectToAction(nameof(Index));
        }
        return View("Index", inputData);
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
