using System;

namespace Example.IoC.Shell
{
    public class Program
    {
        static void Main(string[] args)
        {
            IUserLoader userLoader = new CsvUserLoader(new CsvParser());
            ITimeService timeService = new SystemTimeService();
            IUserPrinter userPrinter = new ConsoleUserPrinter();

            CommandProcessor commandProcessor = new CommandProcessor(userLoader, timeService, userPrinter);
            commandProcessor.PrintUsersWithBirthdayToday();

            Console.ReadLine();
        }
    }
}
