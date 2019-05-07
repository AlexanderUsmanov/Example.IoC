using System.Collections.Generic;
using Example.IoC.Shell;

namespace Example.IoC.Tests
{
    public class TestUserPrinter : IUserPrinter
    {
        public List<User> Output { get; set; } = new List<User>();

        public void PrintUserToConsole(User user)
        {
            Output.Add(user);
        }
    }
}
