using System;
using System.Linq;

namespace _01.SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Reveal")
            {

                string[] commandArgs = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);

                string commandTyp = commandArgs[0];

                if (commandTyp == "InsertSpace")
                {
                    int insertIndex = int.Parse(commandArgs[1]);
                    message = message.Insert(insertIndex, " ");
                }
                else if (commandTyp == "Reverse")
                {
                    string substring = commandArgs[1];

                    if (message.Contains(substring))
                    {
                        int substringIndex = message.IndexOf(substring);
                        message = message.Remove(substringIndex, substring.Length);
                        message = message + string.Join("", substring.Reverse());
                    }
                    else
                    {
                        Console.WriteLine($"error");
                        command = Console.ReadLine();
                        continue;

                    }
                }
                else if (commandTyp == "ChangeAll")
                {
                    string substring = commandArgs[1];
                    string replacementtext = commandArgs[2];

                    message = message.Replace(substring, replacementtext);
                }

                Console.WriteLine(message);

                command = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {message}");

        }
    }
}
