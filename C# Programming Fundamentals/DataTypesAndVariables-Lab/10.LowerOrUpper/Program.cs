﻿using System;

namespace _10.LowerOrUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char character = char.Parse(Console.ReadLine());

            if (char.IsUpper(character))
            {
                Console.WriteLine("upper-case");
            }

            if (char.IsLower(character))
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
