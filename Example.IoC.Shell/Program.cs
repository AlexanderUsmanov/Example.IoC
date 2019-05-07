using System;
using SimpleInjector;

namespace Example.IoC.Shell
{
    public class Program
    {
        static void Main(string[] args)
        {
            SimpleInjector.Container container = new SimpleInjector.Container();
            ConfigureContainer(container);

            CommandProcessor commandProcessor = container.GetInstance<CommandProcessor>();
            commandProcessor.PrintUsersWithBirthdayToday();

            Console.ReadLine();
        }

        private static void ConfigureContainer(SimpleInjector.Container container)
        {
            container.Register<IUserLoader, CsvUserLoader>();
            container.Register<ITimeService, SystemTimeService>();
            container.Register<IUserPrinter, ConsoleUserPrinter>();
            container.Register<ICsvParser, CsvParser>();
            container.Register<CommandProcessor>();

            container.Verify();
        }

        private static void ConfigureContainerByPackages(SimpleInjector.Container container)
        {
            container.RegisterPackages(new [] { typeof(Program).Assembly });

            container.Verify();
        }
    }
}
