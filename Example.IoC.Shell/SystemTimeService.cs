using System;

namespace Example.IoC.Shell
{
    public class SystemTimeService
    {
        public DateTime GetNow()
        {
            return DateTime.Now;
        }
    }
}
