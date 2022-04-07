using System;

namespace BarcodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string barcodeOne = Console.ReadLine();
            string barcodeTwo = Console.ReadLine();

            string firstNumOne = $"{barcodeOne[0]}";
            string firstNumTwo = $"{barcodeTwo[0]}";
            string secondNumOne = $"{barcodeOne[1]}";
            string secondNumTwo = $"{barcodeTwo[1]}";
            string thirdNumOne = $"{barcodeOne[2]}";
            string thirdNumTwo = $"{barcodeTwo[2]}";
            string fourthNumOne = $"{barcodeOne[3]}";
            string fourthNumTwo = $"{barcodeTwo[3]}";

            for (int i = int.Parse(firstNumOne); i <= int.Parse(firstNumTwo); i++)
            {
                for (int j = int.Parse(secondNumOne); j <= int.Parse(secondNumTwo); j++)
                {
                    for (int k = int.Parse(thirdNumOne); k <= int.Parse(thirdNumTwo); k++)
                    {
                        for (int l = int.Parse(fourthNumOne); l <= int.Parse(fourthNumTwo); l++)
                        {
                            if (i % 2 != 0 && j % 2 != 0 && k % 2 != 0 && l % 2 != 0)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
