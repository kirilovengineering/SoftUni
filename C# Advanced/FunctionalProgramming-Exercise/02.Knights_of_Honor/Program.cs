using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(" ").ToList();

            Func<string, string> printSir = name => "Sir " + name;

            foreach (var item in list)
            {
                Console.WriteLine(printSir(item));
            }
        }
    }
}
