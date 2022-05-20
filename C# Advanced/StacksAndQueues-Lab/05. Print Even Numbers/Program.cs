using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<string> evenNumbers = new Queue<string>();

            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    evenNumbers.Enqueue(item.ToString());
                    evenNumbers.Enqueue(", ");
                }
            }

            for (int i = 1; i < evenNumbers.Count;i++)
            {
                i--;
                Console.Write(evenNumbers.Dequeue());
            }
        }
    }
}
