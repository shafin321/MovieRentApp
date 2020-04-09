using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieApp.IRespository;
using MovieApp.Models;
using MovieApp.ViewModels;

namespace MovieApp.Controllers
{
    public class MovieController : Controller
    {
        private readonly IGenre _genre;
        private readonly IMovie _movie;
        public MovieController(IMovie movie, IGenre genre )
        {
            _genre = genre;
            _movie = movie;
        }
        public IActionResult Index()
        {
            var model = _movie.GetAll();

            return View(model);
        }


        [HttpGet]
        public IActionResult Create()
        {
            var list = _genre.GetGenreDropDownList();

            var viewModel = new CreateMovieModel
            {
               GenreList=list

            };


            return View(viewModel);

        }

        [HttpPost]
        public IActionResult Create(CreateMovieModel viewmodel)
        {

            var model = new Movie
            {
                Id=viewmodel.Id,
                Name=viewmodel.Name,
                Genre=viewmodel.Genre,
                GenreId=viewmodel.GenreId


            };
            _movie.Add(model);

            return RedirectToAction("Index");

        }
    }
}