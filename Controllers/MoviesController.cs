using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: movies/random
        public ActionResult Random()
        {

            var viewModel = new RandomMovieViewModel();

            return View(viewModel);
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });

        }

        // GET: movies/edit/{id}
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        // GET: movies/update?movieId=10
        public ActionResult Update(int movieId)
        {
            return Content("MovieID=" + movieId);
        }

        // GET: movies?pageIndex=23&sortBy=Name
        // GET: movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content($"pageIndex={pageIndex}&sortBy={sortBy}");
        }

        [HttpGet]
        [Route("movies/release/{year:regex(\\d{4}):range(1900,2019)}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}