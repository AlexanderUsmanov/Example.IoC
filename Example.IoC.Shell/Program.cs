using System;
using System.IO;

namespace Example.IoC.Shell
{
    public class Program
    {
        static void Main(string[] args)
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

            Console.ReadLine();
        }
    }
}
