using System.Web.Http;
using System.Web.Http.Cors;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ProjectTracking.Infra.CrossCutting.IoC;

namespace ProjectTrackingServices
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var corsAttr = new EnableCorsAttribute("http://localhost:57680", "*", "*");
            config.EnableCors(corsAttr);
            // Web API configuration and services
            //config.EnableCors();
            
            // Web API routes
            config.MapHttpAttributeRoutes();
            
            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling = PreserveReferencesHandling.Objects;
            json.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            //var container = new UnityContainer();
            ConfigureDependencyInjection(config);

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
        }

        private static void ConfigureDependencyInjection(HttpConfiguration config)
        {
            var container = Container.UnityContainer(config);
            config.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}
