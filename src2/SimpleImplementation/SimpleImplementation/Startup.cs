using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Features.Variance;
using Autofac.Integration.WebApi;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using SimpleImplementationModel.EFImplementation;

[assembly: OwinStartup(typeof(SimpleImplementation.Startup))]

namespace SimpleImplementation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Database.SetInitializer(new PeopleDbContextInitialiser());

            var config = new HttpConfiguration();

            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var containerBuilder = new ContainerBuilder();
            
            containerBuilder.RegisterSource(new ContravariantRegistrationSource());

            containerBuilder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            SimpleImplementationModel.Boot.Startup.Initialise(containerBuilder, "mydb");
            
            var container = containerBuilder.Build();



            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            ConfigureAuth(app);
            app.UseAutofacMiddleware(container);
            app.UseAutofacWebApi(config);
            app.UseWebApi(config);
        }
    }
}
