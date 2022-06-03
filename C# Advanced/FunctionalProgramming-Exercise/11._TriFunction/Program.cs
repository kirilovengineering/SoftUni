using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();

            Func<string, int, bool> isGreater = (x, y) => x.Sum(ch => ch) >= y;
            Func<Func<string, int, bool>, List<string>, string> returnFirst = (x, y) => y.FirstOrDefault(s => x(s, sum));

            string result = returnFirst(isGreater, names);
            Console.WriteLine(result);
        }
    }
}
