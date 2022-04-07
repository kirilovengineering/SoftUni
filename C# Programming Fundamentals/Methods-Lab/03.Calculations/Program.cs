using System;

namespace _03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string command = Console.ReadLine();
            Calculator(command);

            static void Calculator (string WhatIsYourCommand)
            {
                if (WhatIsYourCommand == "add")
                {
                    double firstNum = int.Parse(Console.ReadLine());
                    double secondNum = int.Parse(Console.ReadLine());
                    double result = firstNum + secondNum;
                    Console.WriteLine(result);

                }
                else if (WhatIsYourCommand == "multiply")
                {
                    double firstNum = int.Parse(Console.ReadLine());
                    double secondNum = int.Parse(Console.ReadLine());
                    double result = firstNum * secondNum;
                    Console.WriteLine(result);
                }
                else if (WhatIsYourCommand == "subtract")
                {
                    double firstNum = int.Parse(Console.ReadLine());
                    double secondNum = int.Parse(Console.ReadLine());
                    double result = firstNum - secondNum;
                    Console.WriteLine(result);
                }
                else if (WhatIsYourCommand == "divide")
                {
                    double firstNum = int.Parse(Console.ReadLine());
                    double secondNum = int.Parse(Console.ReadLine());
                    double result = firstNum / secondNum;
                    Console.WriteLine(result);
                }
            }
        }
    }
}
