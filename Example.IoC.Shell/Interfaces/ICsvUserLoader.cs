using System.Collections.Generic;

namespace Example.IoC.Shell
{
    public interface IUserLoader
    {
        List<User> LoadUsersFromCsv();
    }
}
