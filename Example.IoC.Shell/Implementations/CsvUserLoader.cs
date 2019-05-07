using System.Collections.Generic;
using System.IO;

namespace Example.IoC.Shell
{
    public class CsvUserLoader : IUserLoader
    {
        public List<User> LoadUsersFromCsv()
        {
            ICsvParser csvParser = new CsvParser();
            using (TextReader textReader = File.OpenText("Users.csv"))
            {
                return csvParser.ParseUsers(textReader);
            }
        }
    }
}
