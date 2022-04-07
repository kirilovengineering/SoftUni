using System;

namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aString = Console.ReadLine();
            string lengthOddOrEven = string.Empty;
            string newAString = string.Empty;

            if (aString.Length % 2 == 0)
            {
                lengthOddOrEven = "Even";
            }
            else
            {
                lengthOddOrEven = "Odd";
            }

            if (lengthOddOrEven == "Even")
            {
                newAString = EvenString(aString);
                Console.WriteLine(newAString);
            }
            else if (lengthOddOrEven == "Odd")
            {
                newAString = OddString(aString);
                Console.WriteLine(newAString);
            }

            static string EvenString(string inString)
            { 
                int inStringLength = inString.Length;
                inStringLength = inStringLength / 2;

                string internalnewAString = string.Empty;
                internalnewAString += inString[inStringLength - 1];
                internalnewAString += inString[inStringLength];
                return internalnewAString;
            }

            static string OddString(string inString)
            {
                int inStringLength = inString.Length - 1;
                inStringLength = inStringLength / 2;

                string internalnewAString = string.Empty;
                internalnewAString += inString[inStringLength];
                return internalnewAString;
            }
        }
    }
}
