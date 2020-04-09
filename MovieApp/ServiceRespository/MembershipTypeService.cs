using Microsoft.AspNetCore.Mvc.Rendering;
using MovieApp.Data;
using MovieApp.IRespository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.ServiceRespository
{
	public class MembershipTypeService : IMemberShipType
	{
		private readonly ApplicationDbContext _context;
		public MembershipTypeService(ApplicationDbContext context)
		{
			_context = context;
		}
		public IEnumerable<SelectListItem> GetMemberDropDownList()
		{

			return _context.MembershipTypes.Select(i => new SelectListItem()
			{

				Text = i.Name,
				Value = i.Id.ToString()
			}

			);
		
		}
	}
}
