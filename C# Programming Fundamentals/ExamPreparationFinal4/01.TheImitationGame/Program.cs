using System;
using System.Linq;

namespace _01.TheImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();


            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Decode")
            {
                string[] cmdInfo = command
                    .Split('|', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string cmdType = cmdInfo[0];

                if (cmdType == "Move")
                {
                    int index = int.Parse(cmdInfo[1]);
                    string letters = message;
                    letters = letters.Substring(0, index);
                    message = message.Remove(0, index);
                    message = message + letters;           
                }
                else if (cmdType == "Insert")
                {
                    int index = int.Parse(cmdInfo[1]);
                    string value = cmdInfo[2];
                    message = message.Insert(index, value);
                }
                else if (cmdType == "ChangeAll")
                {
                    string substring = cmdInfo[1];
                    string replacement = cmdInfo[2];
                    message = message.Replace(substring, replacement);
                }
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
