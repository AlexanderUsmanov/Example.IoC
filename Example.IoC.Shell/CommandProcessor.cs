using System;
using System.Collections.Generic;

namespace Example.IoC.Shell
{
    public class CommandProcessor
    {
        public void PrintUsersWithBirthdayToday()
        {
            IUserLoader userLoader = new CsvUserLoader();
            ITimeService systemTimeService = new SystemTimeService();
            IUserPrinter userPrinter = new ConsoleUserPrinter();
            
            List<User> users = userLoader.LoadUsersFromCsv();
            DateTime now = systemTimeService.GetNow();
            foreach (User user in users)
            {
                if (user.HasBirthdayNow(now))
                {
                    userPrinter.PrintUserToConsole(user);
                }
            }
        }
    }
}
