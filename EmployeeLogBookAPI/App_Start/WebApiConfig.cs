using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace EmployeeLogBookAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // for enable Access-Control-Allow-Origin Or Cors Policies for script request
            //Install-Package Microsoft.AspNet.WebApi.Cors -Version 5.2.7

            var cors = new EnableCorsAttribute(origins: "*", headers: "*", methods: "*");
            config.EnableCors(cors);

            // Web API configuration and services
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
