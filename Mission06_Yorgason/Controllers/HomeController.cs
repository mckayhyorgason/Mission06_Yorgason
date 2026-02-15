using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Yorgason.Models;

namespace Mission06_Yorgason.Controllers;

public class HomeController : Controller
{
    private MovieContext _context;
    
    public HomeController(MovieContext someName)
    {
        _context = someName;
    }
    
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
        _context.MovieList.Add(movie); // add record to database
        _context.SaveChanges();
        
        
        return View();
    }

}