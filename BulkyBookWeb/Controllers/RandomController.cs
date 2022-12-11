using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BulkyBookWeb.Models;

namespace BulkyBookWeb.Controllers;

public class RandomController : Controller
{
    private readonly ILogger<RandomController> _logger;

    public RandomController(ILogger<RandomController> logger)
    {
        _logger = logger;
    }
    public IActionResult IndexRandom()
    {
        return View();
    }
}