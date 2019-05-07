using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Example.IoC.Shell
{
    public class CommandProcessor
    {
        public void Process()
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
                    String userName = lineParts[0];
                    String userEmail = lineParts[1];
                    DateTime userBirthday = DateTime.Parse(lineParts[2]);
                    if ((userBirthday.Month == DateTime.Now.Month)
                        && (userBirthday.Day == DateTime.Now.Day))
                    {
                        Console.WriteLine($"{userName} ({userEmail})");
                    }
                }
            }
        }
    }
}
