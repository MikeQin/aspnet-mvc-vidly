using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class RandomMovieViewModel
    {
        public RandomMovieViewModel()
        {
            var movie = new Movie { Name = "Shrek" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Stephen" },
                new Customer { Name = "Bruce" },
                new Customer { Name = "Charlie" },
                new Customer { Name = "William" }
            };

            Movie = movie;
            Customers = customers;
        }

        public Movie Movie { get; set; }

        public List<Customer> Customers { get; set; }

    }
}