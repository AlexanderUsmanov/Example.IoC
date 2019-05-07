using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Example.IoC.Shell
{
    public class CommandProcessor
    {
        public void PrintUsersWithBirthdayToday()
        {
            CsvUserLoader userLoader = new CsvUserLoader();
            SystemTimeService systemTimeService = new SystemTimeService();
            ConsoleUserPrinter userPrinter = new ConsoleUserPrinter();
            
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
