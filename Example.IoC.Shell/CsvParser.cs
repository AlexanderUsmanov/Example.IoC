using System;
using System.Collections.Generic;
using System.IO;

namespace Example.IoC.Shell
{
    public class CsvParser
    {
        public List<User> ParseUsers(TextReader textReader)
        {
            List<User> result = new List<User>();

            while (true)
            {
                String line = textReader.ReadLine();
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

            return result;
        }
    }
}
