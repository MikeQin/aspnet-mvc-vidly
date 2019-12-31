using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        [HttpGet]
        public ActionResult Index()
        {
            var customers = new RandomMovieViewModel().Customers;

            return View(customers);
        }

        public ActionResult Create()
        {
            ViewBag.Title = "Create Customer";
            ViewBag.Message = "Create Page - Not Implemented Yet.";

            return View();
        }

        public ActionResult Edit()
        {
            ViewBag.Title = "Edit Customer";
            ViewBag.Message = "Edit Page - Not Implemented Yet.";

            return View();
        }

        public ActionResult Details()
        {
            ViewBag.Title = "Customer's Details";
            ViewBag.Message = "Details Page - Not Implemented Yet.";

            return View();
        }

        public ActionResult Delete()
        {
            ViewBag.Title = "Delete Customer";
            ViewBag.Message = "Delete Page - Not Implemented Yet.";

            return View();
        }
    }
}