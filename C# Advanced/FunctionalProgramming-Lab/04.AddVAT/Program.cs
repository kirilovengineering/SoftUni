using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.AddVAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<decimal, decimal> addVAT = x => x * 1.2m;
            string input = Console.ReadLine();
            string[] tokens = input.Split(", ");
            decimal[] nums = tokens.Select(decimal.Parse).ToArray();
            decimal[] numsVAT = nums.Select(addVAT).ToArray();
                   
            // Функционално
            Array.ForEach(numsVAT, x => Console.WriteLine("{0:F2}", x));
        }
    }
}
