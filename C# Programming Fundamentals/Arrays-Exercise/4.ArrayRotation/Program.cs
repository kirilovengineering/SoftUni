using System;
using System.Linq;

namespace _4.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rotationCount = int.Parse(Console.ReadLine());


            for (int rot = 1; rot <= rotationCount; rot++)
            {
                int firstElement = array[0];
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    array[i] = array[i + 1];
                }

                array[array.Length - 1] = firstElement;
            }

            Console.WriteLine(String.Join(" ", array));

        }
    }
}
