using System;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());
            int totalTime = firstTime + secondTime + thirdTime;

            int minets = totalTime / 60;
            int seconds = totalTime % 60;

            if ( seconds < 10 )
            {
                Console.WriteLine($"{minets}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minets}:{seconds}");
            }

        }
    }
}
