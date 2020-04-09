using Microsoft.EntityFrameworkCore;
using MovieApp.Data;
using MovieApp.IRespository;
using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.ServiceRespository
{
	

	public class MovieRepositoryService:IMovie
	{
		private readonly ApplicationDbContext _contex;
		public MovieRepositoryService(ApplicationDbContext context)
		{
			_contex = context;
		}

		public Movie Add(Movie newMovie)
		{
			_contex.Movies.Add(newMovie);
			_contex.SaveChanges();
			return newMovie;
		}

		public Movie Delete(int id)
		{
			var model = _contex.Movies.Find(id);
			_contex.Movies.Remove(model);
			_contex.SaveChanges();
			return model;
		}

		public IEnumerable<Movie> GetAll()
		{
			return _contex.Movies.Include(c => c.Genre);
		}

		public Movie GetById(int id)
		{
			return _contex.Movies.Find(id);
		}
	}
}
