using Autofac;
using Autofac.Integration.Mvc;
using DotnetP5App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;

namespace DotnetP5App
{
    public class ContainerConfig
    {
        internal static void RegisterContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(Startup).Assembly);
            builder.RegisterType<SqlCarData>()
                   .As<ICarData>()
                   .InstancePerRequest();
            builder.RegisterType<CarDBContext>().InstancePerRequest();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            
        }
    }
}
