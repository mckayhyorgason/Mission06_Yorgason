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
        if (ModelState.IsValid)
        {
            try
            {
                _context.MovieList.Add(movie);
                _context.SaveChanges();

                return RedirectToAction("MovieForm"); // Redirect to empty form
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ModelState.AddModelError("", "Something went wrong while saving. Please try again.");
            }
        }

        return View(movie);
    }

    public IActionResult MovieList()
    {
        var movieItem = _context.MovieList
            .ToList();
        
        return View(movieItem);
    }

}