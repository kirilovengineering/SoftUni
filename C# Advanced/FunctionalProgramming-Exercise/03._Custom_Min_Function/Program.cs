using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Начин
            //List<string> list = Console.ReadLine().Split(" ").ToList();
            //HashSet<int> numbers = new HashSet<int>();
            //for (int i = 0; i < list.Count; i++)
            //{
            //    numbers.Add(int.Parse(list[i]));
            //}
            //int min = numbers.Min();
            //Console.WriteLine(min);

            // 2. Начин
            // Фукционално ще стане така
            //List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            //Func<List<int>, int> getMinElement = numbers => numbers.Min();
            //Console.WriteLine(getMinElement(numbers));

            //3.Начин
            //Яко с един ред
            Console.WriteLine(Console.ReadLine().Split(" ").Select(int.Parse).ToList().Min());
        }
    }
}
