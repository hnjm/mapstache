﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcWebRole1
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );
            routes.MapRoute(
             "TMS", // Route name
             "{controller}/{version}/{name}/{z}/{x}/{y}.png", // URL with parameters
             new { controller = "Tms", action = "Index", version = "version", name = "name", x = "x", y = "y", z = "z" });// Parameter defaults

            routes.MapRoute(
            "Utf8Grid", // Route name
            "{controller}/{action}/{z}/{x}/{y}", // URL with parameters
            new { controller = "Utf8Grid", action = "action", x = "x", y = "y", z = "z" });
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}