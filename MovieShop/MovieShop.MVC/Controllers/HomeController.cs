using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieShop.MVC.Models;
using ApplicationCore.Models.Response;
using Infrastructure.Services;
using ApplicationCore.ServiceInterfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MovieShop.MVC.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        private readonly IMovieService _movieService;
        //private readonly MovieShopDbContext _dbContext;
        public HomeController(IMovieService movieService)
        {
            // Abstractions/Contract => Interfaces, 如果这里更改，不会影响到movie server class 
            //_movieService = new MovieService();
            _movieService = movieService;
            //_dbContext = dbContext;
        }


        //http:movieshop.com/Home/index
        //!!!use async type method you need to use Task<>, all the method must be async
        

        //
        public async Task<IActionResult> Index()
        {
            var movies = await _movieService.GetTop30RevenueMovie();
            return View(movies);


            //    // Select top 30 * from Movies order by revenue
            //    // LINQ
            //    // var movies = dbContext.Movies.OrderByDescedning(m=> m.Revenue).Take(30);
            //    // foreach(var m in movies) {}

            //    //!!!!async in a method always comes with await, and 
            //    var movies = await _dbContext.Movies.OrderByDescending(m => m.Revenue).Take(30).ToListAsync();

            //    var topMovies = new List<MovieResponseModel>();

            //    foreach (var movie in movies)
            //    {
            //        var topMovie = new MovieResponseModel();
            //        topMovie.Id = movie.Id;
            //        topMovie.Title = movie.Title;
            //        topMovie.Budget = movie.Budget;

            //        topMovies.Add(topMovie);
            //        //topMovies.Add( new MovieResponseModel
            //        //{
            //        //    Id = movie.Id, 
            //        //    Budget = movie.Budget,
            //        //    Title = movie.Title
            //        //});
            //    }

            //    //var movies = _movieService.GetTop30RevenueMovie();
            //    return View(topMovies);

            //    //var movies = _movieService.GetTop30RevenueMovie();
            //    //return View(movies);
            //    // call the database and get top 30 revenue movies
            //    // passing data from my controller/action method to view using models
            //    // passing data using ViewBag and ViewData
            //    //ViewBag.TotalMovies = movies.Count();
            //    //ViewData["PageTitle"] = "Top Movies Page";
            //    //you return view, data in the IActionResult interface.
            //    //you can specify the viwe name in the view("")
            //    //get moives, and go to views floders to find matched views.


        }





        //[HttpGet/Post]
        public IActionResult Privacy()
        {
            // !!!!!!!!go to view and controller folder and name of view
            return View();

        }

        [HttpGet]
        public IActionResult TopRatedMovies()
        {
            return View("TopMovies");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
