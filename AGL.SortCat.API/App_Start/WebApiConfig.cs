using AGL.SortCat.API.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace AGL.SortCat.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            config.Routes.MapHttpRoute(
                "ResourceNotFound",
                "{*url}",
                new { controller = "Error", action = nameof(ErrorController.ResourceNotFound) });
        }
    }
}
