using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using MovieApp.Models;
using MovieApp.ViewModels;

namespace MovieApp.Controllers
{
    public class RentalController : Controller
    {
        private readonly ApplicationDbContext _context;
        public RentalController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            var model = new Rental();
            var viewmodel = new NewRentalModel
            {
                Customer=model.Customer,
                Movie=model.Movie,
            };

            return View(viewmodel);
        }

        [HttpPost]
        public IActionResult Create(NewRentalModel rentmodel)
        {
            var cutomer = _context.Customers.SingleOrDefault(c => c.Id == rentmodel.CustomerId);

            var movies = _context.Movies.Where(m => rentmodel.MoviesId.Contains(m.Id));

            foreach(var movie in movies) // for each movie i will create rental object
            {
                var rental = new Rental
                {
                    Customer= cutomer,
                    Movie=movie,
                    DateRented=DateTime.Now
                   

                    
                };

                _context.Rentals.Add(rental);

                _context.SaveChanges();

               


            }
            return RedirectToAction("Index");
        }

      
    }
}