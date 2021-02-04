using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assignment3DallinCollinsa.Models;

namespace Assignment3DallinCollinsa.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        //get method for the EnterMovies view
        [HttpGet]
        public IActionResult EnterMovies()
        {
            return View();
        }

        //post method for the EnterMovies view
        [HttpPost]
        public IActionResult EnterMovies(EnterMoviesModel enterMovies)
        {
            //ensures data is valid before putting it into the temporary storage
            if (ModelState.IsValid)
            {
                TempMovieStorage.AddApplication(enterMovies); //calls the AddApplication method in the TempMovieStorage class and passes it the instance of the object
                Response.Redirect("DisplayMovies");
            }

            //loads the EnterMovies view and passes it the instanse of enterMovies
            return View();
        }

        public IActionResult DisplayMovies()
        {

            //passes the Movies list
            return View(TempMovieStorage.Movies);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
