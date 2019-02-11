using Autofac;
using AutoFacConsoleApp.Interfaces;
using System;
using AutoFacConsoleApp.Config;

namespace AutoFacConsoleApp
{
    class Program
    {
        private static IContainer Container;

        static void Main(string[] args)
        {
            Container = ContainerConfig.Configure();

            using (var scope = Container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }

            Console.ReadKey();
        }
    }
}
