using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ExemploWebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Servizi e configurazione dell'API Web

            // Route dell'API Web
            config.MapHttpAttributeRoutes();

            //aki tems uma orta de connfiguracao padrao feito pelo programa
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}", //ex: www.anielle.com.br/api/nome_controller
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
