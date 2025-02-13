using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Mission6.Models;

namespace Mission6.Controllers
{
    public class MovieController : Controller
    {
        private readonly MovieContext _context;

        public MovieController(MovieContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(movie);
                _context.SaveChanges();

                // Return a new, empty movie object to reset the form
                return View(new Movie());
            }

            // If ModelState is not valid, return the current movie with validation errors
            return View(movie);
        }


        public IActionResult ViewMovies()
        {
            var movies = _context.Movies
                .Include(m => m.Category) // To include category names
                .Include(m => m.Rating)   // To include rating names
                .ToList();

            return View(movies);
        }
    }
}