﻿using System;

namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            while (input != "END")
            {
                int number = int.Parse(input);
               VerificationPalindrome(number);

                input = Console.ReadLine().ToUpper();
            }
        }

        public static void VerificationPalindrome(int number)
        {
            char[] numAsText = number.ToString().ToCharArray();
            Array.Reverse(numAsText);
            int num = int.Parse(new string(numAsText));

            Console.WriteLine(number == num ? "true" : "false");
        }
    }
}
