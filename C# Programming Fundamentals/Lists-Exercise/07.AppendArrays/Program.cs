using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                                         .Split('|', StringSplitOptions.RemoveEmptyEntries)
                                         .Reverse()
                                         .ToList();
            List<int> nums = new List<int>();

            foreach (string str in numbers)
            {
                nums.AddRange(str.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                               .Select(int.Parse)
                                                               .ToList());
            }

            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
