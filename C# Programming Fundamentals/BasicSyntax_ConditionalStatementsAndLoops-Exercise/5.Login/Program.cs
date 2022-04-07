using System;

namespace _5.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = string.Empty;

            for (int reverseIndex = userName.Length -1; reverseIndex >= 0; reverseIndex--)
            {
                password += userName[reverseIndex];
            }

            for (int count = 1; count <= 4; count++)
            {
                string enteredPassword = Console.ReadLine();

                if (enteredPassword == password)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }
                else
                {
                    if (count == 4)
                    {
                        Console.WriteLine($"User {userName} blocked!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect password. Try again.");
                        continue;
                    }
                }
            }
        }
    }
}
