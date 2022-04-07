using System;

namespace Barcode2
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            int startNumOnes = startNum / 1 % 10;
            int startNumTens = startNum / 10 % 10;
            int startNumHundreds = startNum / 100 % 10;
            int startNumThousands = startNum / 1000;

            int endNumOnes = endNum / 1 % 10;
            int endNumTens = endNum / 10 % 10;
            int endNumHundreds = endNum / 100 % 10;
            int endNumThousands = endNum / 1000;

            for (int i = startNumThousands; i <= endNumThousands; i++)
            {
                for (int j = startNumHundreds; j <= endNumHundreds; j++)
                {
                    for (int k = startNumTens; k <= endNumTens; k++)
                    {
                        for (int l = startNumOnes; l <= endNumOnes; l++)
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