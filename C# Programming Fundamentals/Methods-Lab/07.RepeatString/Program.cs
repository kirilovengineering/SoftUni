using System;

namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string @string = Console.ReadLine();
            int repeats = int.Parse(Console.ReadLine());

            string notNeedThis =  ConcatenateString(@string, repeats);

            Console.WriteLine(notNeedThis);

            static string ConcatenateString (string forConcatenate, int nuberForConcatenate)
            {
                string bigString = string.Empty;

                for (int i = 1; i <= nuberForConcatenate ; i++)
                {
                    bigString += forConcatenate;
                }
                return bigString;
            }
        }
    }
}
