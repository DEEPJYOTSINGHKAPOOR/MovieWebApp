using MovieWebApp.Models;
using MovieWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieWebApp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            //return View(movie);
            //return Content("Hello World!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index","Home" , new { page=1, sortBy = "name" });

            var customers = new List<Customer> {
                new Customer{
                    Name = "Customer 1"
                },
                new Customer{ 
                    Name = "Customer 2"
                }
                };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie ,
                Customers = customers

            };

            return View(viewModel);
        }

        //GET: Movies/edit/id   - embedded in the url 
        //GET: movies/edit?id=1 - query string
        public ActionResult Edit(int id) {
            return Content("Id "+ id);
        }
        public ActionResult Index(int? pageIndex, string sortBy) {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (sortBy == null) {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex:{0} & sortyBy:{1}", pageIndex, sortBy));
        }

        [Route("movies/released/{year}/{month: regex(\\d{4}) : range(1,12) }")]
        public ActionResult ByReleasedDate(int year, int month) {
            return Content(year+"/"+month);
        }
    }
}