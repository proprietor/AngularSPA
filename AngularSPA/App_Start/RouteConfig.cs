using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AngularSPA
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(name: "Animals",
                url: "Animals",
                defaults: new {controller = "Zoo", action = "Index"});

            routes.MapRoute(name: "Reptiles",
                url: "Reptiles",
                defaults: new { controller = "Zoo", action = "Index" });

            routes.MapRoute(name: "Insects",
                url: "Insects",
                defaults: new { controller = "Zoo", action = "Index" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Zoo", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}