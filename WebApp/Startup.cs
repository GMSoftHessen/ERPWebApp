using Autofac;
using Autofac.Integration.WebApi;

using Newtonsoft.Json.Serialization;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Reflection;
using System.Web;
using System.Web.Http;
using IdentityServer3.AccessTokenValidation;

namespace WebApp
{
    public class Startup
    {
        public static void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            //config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.Formatters.XmlFormatter.SupportedMediaTypes.Clear();
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(
                new MediaTypeHeaderValue("application/json-patch+json")
                );

            //// Adding formatter for Json   
            //config.Formatters.JsonFormatter.MediaTypeMappings.Add(new QueryStringMapping("type", "json", new MediaTypeHeaderValue("application/json")));



            //config.Formatters.JsonFormatter.SerializerSettings.ContractResolver =
            //    new CamelCasePropertyNamesContractResolver();

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name : "DefaultApi",
                routeTemplate : "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional}
                );
           
            // Autofac
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // builder.RegisterType<ChinookDbContext>().WithProperty("DbContext", new ChinookDbContext());

           

            //builder.RegisterAssemblyTypes(typeof(UserRepository).Assembly)
            //        .Where(t => t.Name.EndsWith("Repository"))                  
            //        .As(t => t.GetInterfaces()?.FirstOrDefault(
            //            i => i.Name == "I" + t.Name)).InstancePerRequest();

            //builder.RegisterAssemblyTypes(typeof(UserBO).Assembly)
            //        .Where(t => t.Name.EndsWith("BO"))
            //        .As(t => t.GetInterfaces()?.FirstOrDefault(
            //            i => i.Name == "I" + t.Name)).InstancePerRequest();

            //builder.RegisterAssemblyTypes(typeof(UserViewModel).Assembly)
            //       .Where(t => t.Name.EndsWith("ViewModel"))
            //       .As(t => t.GetInterfaces()?.FirstOrDefault(
            //           i => i.Name == "I" + t.Name)).InstancePerRequest();



            IContainer container = builder.Build();           

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            app.UseIdentityServerBearerTokenAuthentication(new IdentityServerBearerTokenAuthenticationOptions
            {
                Authority = "http://localhost:60539/"
            });

            app.UseWebApi(config)
                .UseAutofacMiddleware(container)
                .UseAutofacWebApi(config);

        }

    }
}