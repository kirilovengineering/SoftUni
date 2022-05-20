using System;
using System.Collections.Generic;

namespace _03._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] elements = Console.ReadLine().Split(' ');
            Stack<string> input = new Stack<string>(elements);

            int sum = 0;
            string sign = string.Empty;

            while (input.Count > 0)
            {
                int value = int.Parse(input.Peek());   
                input.Pop();
                if (input.Count != 0)
                {
                    sign = input.Peek();
                    input.Pop();
                }
                else
                {
                    sum = sum + value;
                }

                if (sign == "+")
                {
                    sum = sum + value;
                }
                else if (sign == "-")
                {
                    sum = sum - value;
                }
                sign = string.Empty;
            }
            Console.WriteLine(sum);
        }
    }
}
