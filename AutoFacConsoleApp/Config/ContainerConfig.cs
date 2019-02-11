using Autofac;
using AutoFacConsoleApp.Interfaces;
using AutoFacConsoleApp.Services;

namespace AutoFacConsoleApp.Config
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<ServiceWriter>().As<IServiceWriter>();
            builder.RegisterType<ServiceCalculator>().As<IServiceCalculator>();

            return builder.Build();
        }
    }
}
