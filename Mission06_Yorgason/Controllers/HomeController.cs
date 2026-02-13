using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Yorgason.Models;

namespace Mission06_Yorgason.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult GetToKnow()
    {
        return View();
    }
    
    [HttpGet]
    public IActionResult MovieForm()
    {
        return View();
    }

    [HttpPost]
    public IActionResult MovieForm(MovieInfo movie)
    {
        return View();
    }

}