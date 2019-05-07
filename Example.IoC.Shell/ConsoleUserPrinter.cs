using System;

namespace Example.IoC.Shell
{
    public class ConsoleUserPrinter : IUserPrinter
    {
        public void PrintUserToConsole(User user)
        {
            Console.WriteLine($"{user.Name} ({user.Email})");
        }
    }
}
