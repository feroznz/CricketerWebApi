using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.WebApi;
using CricketersWebApi.DAL;
using CricketersWebApi.Models;
using WebApplication3.DAL;

namespace WebApplication3
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            //for dependency injecitons.
            var builder = new ContainerBuilder();

            // Register individual components
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<ModelFactory>().As<IModelFactory>();
            builder.RegisterType<StatsService>().As<IStatsService>();

            var container = builder.Build();

            var resolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
        }
    }
}
