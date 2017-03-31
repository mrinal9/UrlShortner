using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyDealUrlShortner
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
              name: "RedirectUrl",
              url: "{hashkey}",
              defaults: new { controller = "UrlShortner", action = "RedirectToActual" }
          );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "UrlShortner", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
