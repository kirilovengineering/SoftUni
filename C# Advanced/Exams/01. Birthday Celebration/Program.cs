using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
//https://github.com/IvalinaNenova/SoftUni-Courses/tree/main/Advanced/Exam%20Practice
namespace _01._Birthday_Celebration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] guest = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> guests = new Queue<int>(guest);
            int[] plates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> food = new Stack<int>(plates);

            int foodWasted = 0;

            while (guests.Any() && food.Any())
            {
                int foodNeeded = guests.Peek();
                int currentPlate = food.Peek();

                while (foodNeeded > 0 && food.Any())
                {
                    foodNeeded -= food.Pop();
                }

                if (foodNeeded < 0)
                {
                    foodWasted += foodNeeded;
                    guests.Dequeue();
                }
                else if (foodNeeded == 0)
                {
                    guests.Dequeue();
                }
            }

            Console.WriteLine(food.Any() 
                ? $"Plates: {string.Join(" ", food)}" 
                : $"Guests: {string.Join(" ", guests)}");
            Console.WriteLine($"Wasted grams of food: {Math.Abs(foodWasted)}");
        }
    }
}
