using Autofac;
using Autofac.Integration.WebApi;
using Greater.Greater;
using Greater.Greater.Interfaces;
using Greater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace Greater.App_Start
{
    public class AutofacConfig
    {
        public static ContainerBuilder ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            var config = GlobalConfiguration.Configuration;

            builder.RegisterType<Greater<Hi>>().As<IGreater<Hi>>().InstancePerDependency();
            builder.RegisterType<Greater<Hello>>().As<IGreater<Hello>>().InstancePerDependency();

            builder.RegisterWebApiFilterProvider(config);

            builder.RegisterWebApiModelBinderProvider();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            return builder;
        }
    }
}