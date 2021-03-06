﻿using Microsoft.AspNetCore.Mvc.Rendering;
using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.ViewModels
{
	public class CreateMovieModel
	{

		public IEnumerable<SelectListItem> GenreList { get; set; }
        public int Id { get; set; }

       
        public string Name { get; set; }

    
        public Genre Genre { get; set; }

       
        public byte GenreId { get; set; }
    }
}
