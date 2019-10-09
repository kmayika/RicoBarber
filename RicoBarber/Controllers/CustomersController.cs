using RicoBarber.Models;
using RicoBarber.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RicoBarber.Controllers
{
    public class CustomersController : Controller
    {
        public ActionResult Index()
        {
            CustomerContext custDetailsContext = new CustomerContext();
            var custDetails = (from a in custDetailsContext.Customers
                               select a).ToList();

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
    }
}