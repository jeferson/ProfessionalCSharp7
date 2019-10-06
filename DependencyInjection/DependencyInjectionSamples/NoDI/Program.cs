using Microsoft.Extensions.DependencyInjection;
using SimpleInjector;
using System;

namespace NoDI
{
    class Program
    {
        static private Container Container;

        static void Main()
        {
            var provider = RegisterServices();

            var controller = Container.GetRequiredService<HomeController>();
            string result = controller.Hello("Stephanie");

            Console.WriteLine(result);

            var controller2 = Container.GetRequiredService<HomeController>();
            string result2 = controller2.Hello("Stephanie");
            Console.WriteLine(result2);
        }

        static IServiceProvider RegisterServices()
        {
            Container = new Container();

            var services = new ServiceCollection();
            services.AddSimpleInjector(Container);
            Container.Register<IGreetingService, GreetingService>(Lifestyle.Singleton); // tem de ser explícito que é singleton
            Container.Register<HomeController>();

            return services.BuildServiceProvider(true).UseSimpleInjector(Container);
        }
    }
}
