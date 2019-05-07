using System.Collections.Generic;
using System.IO;

namespace Example.IoC.Shell
{
    public class CsvUserLoader
    {
        public List<User> LoadUsersFromCsv()
        {
            CsvParser csvParser = new CsvParser();
            using (TextReader textReader = File.OpenText("Users.csv"))
            {
                return csvParser.ParseUsers(textReader);
            }
        }
    }
}
