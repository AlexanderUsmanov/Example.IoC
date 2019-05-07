using System;
using System.Collections.Generic;

namespace Example.IoC.Shell
{
    public class CommandProcessor
    {
        private readonly IUserLoader _userLoader;
        private readonly ITimeService _timeService;
        private readonly IUserPrinter _userPrinter;

        public CommandProcessor(
            IUserLoader userLoader,
            ITimeService timeService,
            IUserPrinter userPrinter
        )
        {
            _userLoader = userLoader;
            _timeService = timeService;
            _userPrinter = userPrinter;
        }

        public void PrintUsersWithBirthdayToday()
        {
            List<User> users = _userLoader.LoadUsersFromCsv();
            DateTime now = _timeService.GetNow();
            foreach (User user in users)
            {
                if (user.HasBirthdayNow(now))
                {
                    _userPrinter.PrintUserToConsole(user);
                }
            }
        }
    }
}
