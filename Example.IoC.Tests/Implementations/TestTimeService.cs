using System;
using Example.IoC.Shell;

namespace Example.IoC.Tests
{
    public class TestTimeService : ITimeService
    {
        public DateTime Now { get; set; } = DateTime.Now;

        public DateTime GetNow()
        {
            return Now;
        }
    }
}
