using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.IRespository
{
	public interface IMovie
	{
		IEnumerable<Movie> GetAll();
		Movie GetById(int id);
		Movie Add(Movie newMovie);
		Movie Delete(int id);
	}
}
