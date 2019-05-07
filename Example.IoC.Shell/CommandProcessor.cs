using System;
using System.Collections.Generic;
using Example.IoC.Shell.Abstractions;

namespace Example.IoC.Shell
{
    public class CommandProcessor
    {
        public void PrintUsersWithBirthdayToday()
        {
            IUserLoader userLoader = ServiceLocator.Singleton.Get<IUserLoader>();
            ITimeService systemTimeService = ServiceLocator.Singleton.Get<ITimeService>();
            IUserPrinter userPrinter = ServiceLocator.Singleton.Get<IUserPrinter>();

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
