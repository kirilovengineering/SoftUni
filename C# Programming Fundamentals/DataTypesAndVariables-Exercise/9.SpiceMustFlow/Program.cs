using System;

namespace _9.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startFlow = int.Parse(Console.ReadLine());
            int leftFlow = 0;
            int days = 0;
            while (startFlow >= 100)
            {
                days++;
                if (days == 1)
                {
                    leftFlow = startFlow - 26;
                }
                else
                {
                    leftFlow += startFlow - 26;
                }
                startFlow -= 10;
            }
            if (leftFlow >= 26)
            {
                leftFlow -= 26;
            }
            else
            {
                leftFlow = 0;
            }

            Console.WriteLine(days);
            Console.WriteLine(leftFlow);
        }
    }
}
