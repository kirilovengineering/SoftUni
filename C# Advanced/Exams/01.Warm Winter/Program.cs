using System;
using System.Collections.Generic;
using System.Linq;
//https://github.com/IvalinaNenova/SoftUni-Courses/tree/main/Advanced/Exam%20Practice
namespace _01.Warm_Winter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] hat = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> hats = new Stack<int>(hat);
            int[] scraf = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> scrafs = new Queue<int>(scraf);

            List<int> sets = new List<int>();

            while (hats.Any() && scrafs.Any())
            {
                int hatForSet = hats.Pop();
                int scrafForSet = scrafs.Peek();
 
                if (hatForSet > scrafForSet)
                {
                    sets.Add(hatForSet + scrafForSet);

                    scrafs.Dequeue();

                }
                else if (hatForSet == scrafForSet)
                {
                    scrafs.Dequeue();
                    hats.Push(hatForSet + 1);
                }
            }
            Console.WriteLine($"The most expensive set is: {sets.Max()}");
            Console.WriteLine(string.Join(" ", sets));

        }
    }
}
