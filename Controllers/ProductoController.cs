using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PrimerProyecto.Models;

namespace PrimerProyecto.Controllers;

public class ProductoController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [Route("action")]
    public IActionResult About()
    {
        return View();
    }
}