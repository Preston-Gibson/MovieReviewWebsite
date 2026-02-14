using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MovieReviewWebsite.Models;

namespace MovieReviewWebsite.Controllers;

public class HomeController : Controller
{
    private MovieReviewContext _context;
    public HomeController(MovieReviewContext movieReviewContext)
    {
        _context = movieReviewContext;
    }
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult GetToKnowJoel()
    {
        return View();
    }

    [HttpGet]
    public IActionResult AddMovie()
    {
        ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "Name");
        ViewBag.Ratings = new SelectList(_context.Ratings, "RatingId", "Name");
        ViewBag.Directors = _context.Directors.ToList();
        return View();
    }

    [HttpPost]
    public IActionResult AddMovie(Movie movie, int? directorId)
    {
        // Save Movie first
        _context.Movies.Add(movie);
        _context.SaveChanges();

        // If a Director was selected, create MovieDirector relationship
        if (directorId.HasValue)
        {
            var movieDirector = new MovieDirector
            {
                MovieId = movie.MovieId,
                DirectorId = directorId.Value
            };

            _context.MovieDirectors.Add(movieDirector);
        }

        _context.SaveChanges();

        return RedirectToAction("Index");
    }
    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}