using System;

namespace Example.IoC.Shell
{
    public class ConsoleUserPrinter
    {
        public void PrintUserToConsole(User user)
        {
            Console.WriteLine($"{user.Name} ({user.Email})");
        }
    }
}
