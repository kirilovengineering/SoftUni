using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parkingRegister = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string cmdType = cmdArgs[0];
                string username = cmdArgs[1];

                if (cmdType == "register")
                {
                    string licensePlateNumber = cmdArgs[2];
                    RegisterUser(parkingRegister, username, licensePlateNumber);
                }

                else if (cmdType == "unregister")
                {
                    Unregister(parkingRegister, username);
                }

            }

            foreach (var KeyValuePear in parkingRegister)
            {
                string username = KeyValuePear.Key;
                string licensePlateNumber = KeyValuePear.Value;
                Console.WriteLine($"{username} => {licensePlateNumber}");
            }
        }

        static void RegisterUser(Dictionary<string, string> parkingRegister, string username, string licensePlateNumber)
        {
            if (parkingRegister.ContainsKey(username))
            {
                string licenseNumberRegistred = parkingRegister[username];

                Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
            }
            else
            {
                parkingRegister[username] = licensePlateNumber;

                Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
            }
        }

        static void Unregister(Dictionary<string, string> parkingRegister, string username)
        {
            if (!parkingRegister.ContainsKey(username))
            {
                Console.WriteLine($"ERROR: user {username} not found");
            }
            else 
            {
                parkingRegister.Remove(username);
                Console.WriteLine($"{username} unregistered successfully");
            }
        }
    }
}
