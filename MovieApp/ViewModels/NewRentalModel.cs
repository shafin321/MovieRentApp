using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.ViewModels
{
	public class NewRentalModel
	{
		public int CustomerId { get; set; }
		public IEnumerable<int> MoviesId { get; set; }

		public Customer Customer { get; set; }
		public  Movie Movie { get; set; }
	}
}
