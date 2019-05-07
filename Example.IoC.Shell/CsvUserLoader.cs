using System;
using System.Collections.Generic;
using System.IO;

namespace Example.IoC.Shell
{
    public class CsvUserLoader
    {
        public List<User> LoadUsersFromCsv()
        {
            List<User> result = new List<User>();

            using (StreamReader streamReader = File.OpenText("Users.csv"))
            {
                while (true)
                {
                    String line = streamReader.ReadLine();
                    if (String.IsNullOrEmpty(line))
                    {
                        break;
                    }

                    String[] lineParts = line.Split(';');
                    User user = new User
                    {
                        Name = lineParts[0],
                        Email = lineParts[1],
                        Birthday = DateTime.Parse(lineParts[2])
                    };
                    result.Add(user);
                }
            }

            return result;
        }
    }
}
