using System;

namespace _06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = string.Empty;

            output += input[0];
            int j = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (output[j] == input[i + 1])
                {
                    //nothing to do
                }
                else
                {
                    output += input[i + 1];
                    j++;
                }
            }

            Console.WriteLine(output);
        }
    }
}
