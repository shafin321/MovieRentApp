using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using MovieApp.IRespository;
using MovieApp.Models;
using MovieApp.ViewModels;

namespace MovieApp.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IMemberShipType _memberType;
        private readonly ApplicationDbContext _context;
        private readonly ICustomer _customer;
        public CustomerController(ICustomer customer,ApplicationDbContext context, IMemberShipType memberType)
        {

            _customer = customer;
            _context = context;
            _memberType = memberType;


        }
        public IActionResult Index()
        {

            var model = _customer.GetAll();

            



            return View(model);
                
        }

        [HttpGet]
        public IActionResult Create()
        {
            var memberType = _context.MembershipTypes;
            var list = _memberType.GetMemberDropDownList();

            var viewmodel = new CreateCustomerMoel
            {
                MembershipTypeList = memberType,
                TypeList=list,
                
            };
           
            return View(viewmodel);
            
            
        }

        [HttpPost]
        public IActionResult Create( CreateCustomerMoel viewmodel)
        {
            var membership = _context.MembershipTypes;

            var customer = new Customer
            {
                Id=viewmodel.Id,
                Name=viewmodel.Name,
                IsSubscribedToNewsletter=viewmodel.IsSubscribedToNewsletter,
                MembershipType=viewmodel.MembershipType,
                MembershipTypeId=viewmodel.MembershipTypeId,
               
            };
            _customer.Add(customer);

            return RedirectToAction("Index");

        }

        public IActionResult Delete(int id)
        {

            _customer.Delete(id);
            return RedirectToAction("Index");
        }
    }
}