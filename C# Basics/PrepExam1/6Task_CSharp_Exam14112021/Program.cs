using System;

namespace _6Task_CSharp_Exam14112021
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            int t = int.Parse(Console.ReadLine());

            for (int i = 2; i <= r; i+=2)
            {
                for (int j = 2; j <= s; j++)
                {
                    for (int k = 2; k <= t; k+=2)
                    {
                        if (j == 2 || j == 3 || j == 5 || j == 7)
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
            }
        }
    }
}
