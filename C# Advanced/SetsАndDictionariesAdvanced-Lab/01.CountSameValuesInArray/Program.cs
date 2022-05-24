using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValuesInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var countByNums = new Dictionary<double, int>();
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            foreach (var num in nums)
            {
                if (countByNums.ContainsKey(num))
                {
                    countByNums[num]++;

                }
                else
                {
                    countByNums[num] = 1; ;
                }
            }

            foreach (var pairs in countByNums)
            {
                Console.WriteLine(pairs.Key + " - " + pairs.Value + " times");
            }
             
        }
    }
}
