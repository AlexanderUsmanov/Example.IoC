using System;

namespace Example.IoC.Shell
{
    public class SystemTimeService : ITimeService
    {
        public DateTime GetNow()
        {
            return DateTime.Now;
        }
    }
}
