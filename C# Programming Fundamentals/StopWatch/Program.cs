using System;
using System.Diagnostics;
using System.Threading;

namespace StopWatch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(10);
                Console.Clear();
            }

            sw.Stop();
            TimeSpan timeTaken = sw.Elapsed;
            Console.WriteLine(timeTaken);
            sw.Restart();
        }
    }
}
