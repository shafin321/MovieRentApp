using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.IRespository
{
	 public interface ICustomer
	{

		IEnumerable<Customer> GetAll();
		Customer GetById(int id);

		Customer Add(Customer newCustomer);
		Customer Delete(int id);
		Customer Update(Customer upateCustomer);


	}
}
