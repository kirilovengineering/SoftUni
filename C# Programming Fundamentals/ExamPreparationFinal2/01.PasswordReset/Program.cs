using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password  = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Done")
            {

                string[] commandArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string comamndType = commandArgs[0];

                if (comamndType == "TakeOdd")
                {
                    char[] oddChars = password.
                        Where((symbol, index) => index % 2 != 0 )
                        .ToArray();

                    password = string.Join("", oddChars);
                    Console.WriteLine($"{password}");
                }
                else if (comamndType == "Cut")
                {
                    int indexForRemoving = int.Parse(commandArgs[1]);
                    int lengthForRemoving = int.Parse(commandArgs[2]);

                    password = password.Remove(indexForRemoving, lengthForRemoving);
                    Console.WriteLine($"{password}");
                }
                else if (comamndType == "Substitute")
                {
                    string substring = commandArgs[1];
                    string substitute = commandArgs[2];

                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, substitute);
                        Console.WriteLine($"{password}");
                    }
                    else
                    {
                        Console.WriteLine($"Nothing to replace!");
                    }
                }

                command = Console.ReadLine(); 
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}
