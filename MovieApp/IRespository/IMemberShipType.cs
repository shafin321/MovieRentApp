﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.IRespository
{
	public interface IMemberShipType
	{
		
		IEnumerable<SelectListItem> GetMemberDropDownList();
	}
}
