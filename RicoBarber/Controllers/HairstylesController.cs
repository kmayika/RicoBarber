using RicoBarber.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RicoBarber.Controllers
{
    public class HairstylesController : Controller
    {
        // GET: Hairstyles/
        public ActionResult Index()
        {
            CustomerContext context = new CustomerContext();
            List<HairstylesModel> hairstyleList = context.Hairstyles.ToList();
            return View(hairstyleList);
        }
    }
}