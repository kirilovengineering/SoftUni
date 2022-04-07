using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double s = r * 100;
            int a = 0, b = 0, c = 0, d = 0, e = 0, f = 0, g = 0, h = 0;
            int t = 0;

            a = (int)Math.Floor(s / 200);
            s -= (a * 200);
            b = (int)Math.Floor(s / 100);
            s -= (b * 100);
            c = (int)Math.Floor(s / 50);
            s -= (c * 50);
            d = (int)Math.Floor(s / 20);
            s -= (d * 20);
            e = (int)Math.Floor(s / 10);
            s -= (e * 10);
            f = (int)Math.Floor(s / 5);
            s -= (f * 5);
            g = (int)Math.Floor(s / 2);
            s -= (g * 2);
            h = (int)Math.Floor(s / 1);
            s -= (h * 1);

            t = a + b + c + d + e + f + g + h;
            Console.WriteLine($"{t}");
        }
    }
}

