using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MicroLinksAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{id}",
                defaults: new { controller = "Links", id = RouteParameter.Optional }
            );
        }
    }
}
