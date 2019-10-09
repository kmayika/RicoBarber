using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace RicoBarber
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //this method will help not create a DB if already exists
            Database.SetInitializer<RicoBarber.Models.CustomerContext>(null);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
