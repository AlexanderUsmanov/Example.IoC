using System.Collections.Generic;
using Example.IoC.Shell;

namespace Example.IoC.Tests
{
    public class TestUserLoader : IUserLoader
    {
        public List<User> Users { get; set; } = new List<User>();

        public List<User> LoadUsersFromCsv()
        {
            return Users;
        }
    }
}
