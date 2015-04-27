using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace StudentsApplication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

         

                routes.MapRoute(
                name: "StudenstDisplay",
                url:  "Students/{id}",                
                constraints: new {id= "[0-9]+"} ,
                defaults: new { controller = "Students", action = "Details" }
            );

             routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",                
             
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
