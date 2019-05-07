using System.Collections.Generic;
using System.IO;

namespace Example.IoC.Shell
{
    public class CsvUserLoader : IUserLoader
    {
        private readonly ICsvParser _csvParser;

        public CsvUserLoader(ICsvParser csvParser)
        {
            _csvParser = csvParser;
        }

        public List<User> LoadUsersFromCsv()
        {
            using (TextReader textReader = File.OpenText("Users.csv"))
            {
                return _csvParser.ParseUsers(textReader);
            }
        }
    }
}
