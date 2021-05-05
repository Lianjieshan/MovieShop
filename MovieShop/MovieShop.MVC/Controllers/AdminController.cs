using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Models.Request;
using Microsoft.AspNetCore.Mvc;

namespace MovieShop.MVC.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult CreateMovie(string title, decimal budget, decimal revenue, string
        //     TITLE, decimal bud)
        //{
        //    // take the information from the View and Save it to Database
        //    return View();

        //}

        [HttpPost]
        public IActionResult CreateMovie(MovieCreateRequestModel movieCreateRequestModel)
        {
            // take the information from the View and Save it to Database
            return View();

        }

        

        [HttpGet]
        public IActionResult CreateMovie() 
        {
            // will show empty page so that admin can enter movie information
            return View();
        
        }


    }

    
}
