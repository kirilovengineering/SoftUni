﻿using System;

namespace _05.DecryptingMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string message = string.Empty;

            for (int i = 0; i < n; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                message += (char)(key + symbol);
            }

            Console.WriteLine(message);
        }
    }
}
