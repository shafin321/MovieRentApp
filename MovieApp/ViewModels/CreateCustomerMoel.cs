using Microsoft.AspNetCore.Mvc.Rendering;
using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.ViewModels
{
	public class CreateCustomerMoel
	{

        public int Id { get; set; }


        public string Name { get; set; }

        public bool IsSubscribedToNewsletter
        {
            get; set;
        }

        public MembershipType MembershipType { get; set; }
        public IEnumerable<SelectListItem> TypeList { get; set; }

        public int MembershipTypeId { get; set; }
        public IEnumerable<MembershipType> MembershipTypeList { get; set; }
    }
}

