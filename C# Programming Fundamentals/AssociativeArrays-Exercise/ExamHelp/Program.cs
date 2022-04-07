using System;
using System.Collections.Generic;

namespace ExamHelp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> Dictionary = new Dictionary<string, int>();

            foreach (KeyValuePair<string, int> KeyValuePair in Dictionary)
            {
                Console.WriteLine($"{KeyValuePair.Key} -> {KeyValuePair.Value}");
            }

        }
    }
}
