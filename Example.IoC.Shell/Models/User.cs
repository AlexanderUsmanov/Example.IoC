using System;
using System.Collections.Generic;
using System.Text;

namespace Example.IoC.Shell
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }

        public bool HasBirthdayNow(DateTime now)
        {
            return (this.Birthday.Month == now.Month)
                   && (this.Birthday.Day == now.Day);
        }
    }
}
