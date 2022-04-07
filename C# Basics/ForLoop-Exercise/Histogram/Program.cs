using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int p1Number = 0, p2Number = 0, p3Number = 0, p4Number = 0, p5Number = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int digit = int.Parse(Console.ReadLine());
                if (digit < 200)
                {
                    p1Number++;
                }
                else if (digit < 400)
                {
                    p2Number++;
                }
                else if (digit < 600)
                {
                    p3Number++;
                }
                else if (digit < 800)
                {
                    p4Number++;
                }
                else if (digit >= 800)
                {
                    p5Number++;
                }
            }
            double p1Percentage, p2Percentage, p3Percentage, p4Percentage, p5Percentage;
            p1Percentage = (double)p1Number / n * 100;
            p2Percentage = (double)p2Number / n * 100;
            p3Percentage = (double)p3Number / n * 100;
            p4Percentage = (double)p4Number / n * 100;
            p5Percentage = (double)p5Number / n * 100;

            Console.WriteLine($"{p1Percentage:F2}%");
            Console.WriteLine($"{p2Percentage:F2}%");
            Console.WriteLine($"{p3Percentage:F2}%");
            Console.WriteLine($"{p4Percentage:F2}%");
            Console.WriteLine($"{p5Percentage:F2}%");
        }
    }
}
