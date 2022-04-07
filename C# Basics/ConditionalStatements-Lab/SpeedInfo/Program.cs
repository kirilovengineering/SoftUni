using System;

namespace SpeedInfo
{
    class Program
    {
        static void Main(string[] args)
        {
// При скорост до 10(включително) отпечатайте & quot; slow & quot;
// При скорост над 10 и до 50(включително) отпечатайте & quot; average & quot;
// При скорост над 50 и до 150(включително) отпечатайте & quot; fast & quot;
// При скорост над 150 и до 1000(включително) отпечатайте & quot; ultra fast&quot;
// При по-висока скорост отпечатайте &quot; extremely fast&quot;
            double a = double.Parse(Console.ReadLine());
            if (a <= 10)
            {
                Console.WriteLine("slow");
            }
            else if ((a > 10) && (a <= 50))
            {
                Console.WriteLine("average");
            }
            else if ((a > 50) && (a <= 150))
            {
                Console.WriteLine("fast");
            }
            else if ((a > 150) && (a <= 1000))
            {
                Console.WriteLine("ultra fast");
            }
            else if ((a > 1000))
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
