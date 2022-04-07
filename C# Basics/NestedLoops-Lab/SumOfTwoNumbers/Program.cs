using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int beginingNum = 0;
            int endNum = 0;
            int magicNum = 0;

            beginingNum = int.Parse(Console.ReadLine());
            endNum = int.Parse(Console.ReadLine());
            magicNum = int.Parse(Console.ReadLine());

            int combinationNum = 0;
            int sum = 0;
            int combinationNumЕquality = 0;

            for (int i = beginingNum; i <= endNum; i++)
            {
                for (int j = beginingNum; j <= endNum; j++)
                {
                    sum = i + j;
                    combinationNum++;
                    if (sum == magicNum)
                    {
                        Console.WriteLine($"Combination N:{combinationNum} ({i} + {j} = {magicNum})");
                        combinationNumЕquality++;
                        return;
                    }
                }
            }
            if (combinationNumЕquality == 0)
            {
                Console.WriteLine($"{combinationNum} combinations - neither equals {magicNum}");
            }
        }
    }
}
