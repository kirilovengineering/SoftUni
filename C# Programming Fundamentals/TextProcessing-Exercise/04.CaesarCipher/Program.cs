using System;
using System.Diagnostics;

namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string output = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                int temp = (int)input[i];
                int j = 0;
                j = temp + 3;
                string cipherTemp = ((char)j).ToString();
                output += cipherTemp;
            }
            Console.WriteLine(output);
        }
    }
}
