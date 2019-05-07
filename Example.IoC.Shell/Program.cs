using System;

namespace Example.IoC.Shell
{
    public class Program
    {
        static void Main(string[] args)
        {
            var commandProcessor = new CommandProcessor();
            commandProcessor.PrintUsersWithBirthdayToday();

            Console.ReadLine();
        }
    }
}
