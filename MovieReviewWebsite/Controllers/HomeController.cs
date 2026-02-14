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
        return View();
    }

    [HttpPost]
    public IActionResult AddMovie(MovieReview movieReview)
    {
        _context.MovieReviews.Add(movieReview);
        _context.SaveChanges();
        
        return View();
    }
    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}