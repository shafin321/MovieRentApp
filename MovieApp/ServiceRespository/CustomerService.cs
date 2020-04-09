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

	public class CustomerService : ICustomer
	{
		private readonly ApplicationDbContext _context;
		public CustomerService(ApplicationDbContext context)
		{
			_context = context;

		}
		public Customer Add(Customer newCustomer)
		{
			_context.Customers.Add(newCustomer);
			_context.SaveChanges();
			return newCustomer;
		}

		public Customer Delete(int id)
		{
			var model = _context.Customers.Find(id);
			_context.Remove(model);
			_context.SaveChanges();

			return model;
		}

		public IEnumerable<Customer> GetAll()
		{
		return	_context.Customers.Include(c=>c.MembershipType);
		}

		public Customer GetById(int id)
		{
			return _context.Customers.Find(id);
		}

		public Customer Update(Customer upateCustomer)
		{
			throw new NotImplementedException();
		}
	}
}
