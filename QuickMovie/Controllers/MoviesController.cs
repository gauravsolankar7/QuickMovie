using Microsoft.AspNetCore.Mvc;
using QuickMovie.Models;

namespace QuickMovie.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Random()
        {
            var movie = new Movie() { Id = 1, Name = "Inception" };
            return View(movie);
        }
    }
}
