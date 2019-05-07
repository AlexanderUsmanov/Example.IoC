using System;
using Example.IoC.Shell.Abstractions;

namespace Example.IoC.Shell
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConfigureServiceLocator(ServiceLocator.Singleton);

            CommandProcessor commandProcessor = ServiceLocator.Singleton.Get<CommandProcessor>();
            commandProcessor.PrintUsersWithBirthdayToday();

            Console.ReadLine();
        }

        private static void ConfigureServiceLocator(ServiceLocator sl)
        {
            sl.Add<CommandProcessor>(new CommandProcessor());
            sl.Add<IUserLoader>(new CsvUserLoader());
            sl.Add<ITimeService>(new SystemTimeService());
            sl.Add<IUserPrinter>(new ConsoleUserPrinter());
            sl.Add<ICsvParser>(new CsvParser());
        }
    }
}
