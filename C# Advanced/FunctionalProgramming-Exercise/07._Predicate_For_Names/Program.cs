using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Predicate_For_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            Func<string, bool> predicate = name => name.Length <= length;

            List<string> names = Console.ReadLine()
                                               .Split(" ")
                                               .ToList();

            foreach (var item in names)
            {
                if (predicate(item))
                {
                    Console.WriteLine(item);
                }

            }
        }
    }
}
