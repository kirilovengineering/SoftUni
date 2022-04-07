using System;
using System.Text;

namespace _07.RepeatString_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string @string = Console.ReadLine();
            int repeats = int.Parse(Console.ReadLine());

            string notNeedThis = ConcatenateString(@string, repeats);

            Console.WriteLine(notNeedThis);



        }

        static string ConcatenateString(string forConcatenate, int nuberForConcatenate)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 1; i <= nuberForConcatenate; i++)
            {
                stringBuilder.Append(forConcatenate);
            }
            return stringBuilder.ToString();
        }
    }
}
