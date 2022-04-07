using System;

namespace _01.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputString = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Random random = new Random();

            for (int i = 0; i < inputString.Length; i++)
            {
                int randomIndex = random.Next(0, inputString.Length - i);
                string shiftWord = inputString[i];
                inputString[i] = inputString[randomIndex];
                inputString[randomIndex] = shiftWord;
            }
            Console.WriteLine(string.Join(Environment.NewLine, inputString));
        }
    }
}
