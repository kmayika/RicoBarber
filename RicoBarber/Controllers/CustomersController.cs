using RicoBarber.Models;
using RicoBarber.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;

namespace RicoBarber.Controllers
{
    public class CustomersController : Controller
    {
        public ActionResult Index(int hairstyleId)
        {
            CustomerContext custDetailsContext = new CustomerContext();
            var custDetails = custDetailsContext.Customers.Where(cust => cust.HairstyleId == hairstyleId).ToList();

            var custViewModel = new CustomerViewModel
            {
                Customer = custDetails
            };
            return View(custViewModel);
        }

        // GET: Customers/Details/id
        public ActionResult Details(int id)
        {
            CustomerContext custDetailsContext = new CustomerContext();
            var custDetails = (from a in custDetailsContext.Customers
                               where a.CustomerId == id
                                           select a).ToList();

            var custViewModel = new CustomerViewModel
            {
                Customer = custDetails
            };
            return View(custViewModel);
        }

        public ActionResult GetAllCustomers()
        {
            BusinessLayer.Customers getCustomers = new BusinessLayer.Customers();
            var customers = getCustomers.Customer.ToList();



            return View(customers);
        }
    }
}