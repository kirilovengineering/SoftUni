using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(" ").ToList();
            HashSet<int> numbers = new HashSet<int>();
            for (int i = 0; i < list.Count; i++)
            {
                numbers.Add(int.Parse(list[i]));
            }
            int min = numbers.Min();
            Console.WriteLine(min);
        }
    }
}
