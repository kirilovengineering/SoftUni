using System;
using System.Collections.Generic;

namespace _04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int startNumber = int.Parse(input.Split(" ")[0]);
            int endNumber = int.Parse(input.Split(" ")[1]);

            List<int> numbers = new List<int>();
            for (int number = startNumber; number <= endNumber; number++)
            {
                numbers.Add(number);
            }

            Predicate<int> predicate = null; // просто декларираме предикат
            //true е четно
            //folse е нечетно
            string type = Console.ReadLine();
            if (type == "even")
            {
                predicate = number => number % 2 == 0;
            }
            else if (type == "odd")
            {
                predicate = number => number % 2 != 0;
            }

            Console.WriteLine(string.Join(" ", numbers.FindAll(predicate)));

            //Predicate<int> isEven = number => number % 2 == 0;
            //string type = Console.ReadLine();
            //if (type =="even")
            //{
            //    foreach (var item in numbers)
            //    {
            //        if (isEven(item))
            //        {
            //            Console.WriteLine(item + " ");
            //        }
            //    }
            //}
            //else if (type == "odd")
            //{
            //    foreach (var item in numbers)
            //    {
            //        if (!isEven(item))
            //        {
            //            Console.WriteLine(item + " ");
            //        }
            //    }
            //}
        }
    }
}
