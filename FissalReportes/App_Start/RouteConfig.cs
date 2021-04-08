using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FissalReportes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            
            routes.MapRoute(
                name: "Propiedad",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Reportes", action = "AtendidosPorRegion", id = UrlParameter.Optional }
            );
        }
    }
}
