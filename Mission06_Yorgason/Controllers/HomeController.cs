using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        ViewBag.Categories = _context.Categories.ToList();
        
        return View();
    }

    [HttpPost]
    public IActionResult MovieForm(MovieInfo movie)
    {
        if (ModelState.IsValid)
        {
            try
            {
                _context.Movies.Add(movie);
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
        var movieItem = _context.Movies
            .Include(x => x.Category)
            .ToList();
        
        return View(movieItem);
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var movieToEdit = _context.Movies
            .Single(x => x.MovieId == id);
        
        ViewBag.Categories = _context.Categories.ToList();
        
        return View("MovieForm",  movieToEdit);
    }

}