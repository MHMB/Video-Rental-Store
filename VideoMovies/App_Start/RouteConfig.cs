using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VideoMovies
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //following method is easier in big projects and more human readable
            routes.MapMvcAttributeRoutes();
            //or you can do this one but not suggested
            //routes.MapRoute(
            //    "MoviesByReleaseDate",
            //    "movies/released/{year}/{month}",
            //    new { controller= "Movies", action="ByReleaseDate" },
            //    new { year = @"\d{4}", month = @"\d{2}" }
            //    //new {year = @"2015|2016", month = @"\d{2}"}
            //    );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
