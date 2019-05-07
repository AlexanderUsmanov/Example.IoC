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
                    if ((user.Birthday.Month == DateTime.Now.Month)
                        && (user.Birthday.Day == DateTime.Now.Day))
                    {
                        Console.WriteLine($"{user.Name} ({user.Email})");
                    }
                }
            }
        }
    }
}
