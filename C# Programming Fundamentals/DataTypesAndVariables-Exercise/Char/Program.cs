using System;

namespace _4.SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Representation ..example 'A' or 65 .... Imput Simbol:");
            char currentCh = char.Parse(Console.ReadLine());
            int currentChCode = (int)currentCh;

            

            Console.WriteLine($"Data type char: {currentCh}");
            Console.WriteLine($"Data type char Code: {currentChCode}");
            Console.WriteLine($"Data type char.ToString: {currentCh.ToString()}");
            Console.WriteLine($"Data type char Code.ToString: {currentChCode.ToString()}");

            Console.OutputEncoding = System.Text.Encoding.UTF8; 
            char ch = '\u00B1';
            Console.WriteLine(ch);//This is +-


        }
    }
}

