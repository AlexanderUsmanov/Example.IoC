using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Example.IoC.Shell
{
    public class CommandProcessor
    {
        public void PrintUsersWithBirthdayToday()
        {
            List<User> users = LoadUsersFromCsv();
            DateTime now = GetNow();
            foreach (User user in users)
            {
                if (user.HasBirthdayNow(now))
                {
                    PrintUserToConsole(user);
                }
            }
        }

        private List<User> LoadUsersFromCsv()
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

        private DateTime GetNow()
        {
            return DateTime.Now;
        }

        private void PrintUserToConsole(User user)
        {
            Console.WriteLine($"{user.Name} ({user.Email})");
        }
    }
}
