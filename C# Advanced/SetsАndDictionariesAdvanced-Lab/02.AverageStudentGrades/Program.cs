using System;
using System.Linq;

namespace _02.AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse)
                .OrderByDescending(x => x).ToList().Take(3);

            Console.WriteLine(String.Join(" ", nums));

            // По друг начин
            //       var nums = Console.ReadLine().Split(' ').Select(int.Parse)
            //      .OrderByDescending(x => x).ToList();
            //for (int i = 0; i < 3; i++)
            //{
            //    if (i < nums.Count)
            //    {
            //        Console.WriteLine(nums[i] + " ");
            //    }
            //}

        }
    }
}
