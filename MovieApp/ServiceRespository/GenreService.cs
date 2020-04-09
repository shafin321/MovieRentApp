using Microsoft.AspNetCore.Mvc.Rendering;
using MovieApp.Data;
using MovieApp.IRespository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.ServiceRespository
{
	public class GenreService:IGenre
	{
		private readonly ApplicationDbContext _context;
		public GenreService(ApplicationDbContext context)
		{
			_context = context;
		}

		public IEnumerable<SelectListItem> GetGenreDropDownList()
		{
			

			return _context.Genres.Select(i => new SelectListItem()
			{
				Text = i.Name,
				Value = i.Id.ToString()

			}); 
		
		}
	}
}
