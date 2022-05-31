using System;
using System.Linq;

namespace _01.SortEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = Console.ReadLine()
            //    .Split(new String[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
            //    .Select(n => int.Parse(n))//maping (преобразуване)функция - приема стринг => връща число
            //    .Where(n => n % 2 == 0) //предикат - прима число => връща true, false
            //    .OrderBy(n => n)//Селектрона фукция - взима обект и връща ключа, по който ще сортираме
            //    .ToArray();
            //string result = string.Join(", ", numbers);
            //Console.WriteLine(result);


            //Показателен пример за функционално програмиране разширено
            Func<string, int> funcParsToInt = x => int.Parse(x);
            Func<int, bool> isEven = x => x % 2 == 0;
            Func<int, int> identity = x => x;

            string input = Console.ReadLine();
            string[] tokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            int[] nums = tokens.Select(funcParsToInt).ToArray();
            int[] evenNums = nums.Where(isEven).ToArray();
            int[] orderedEvenNums = evenNums.OrderBy(identity).ToArray();

            Console.WriteLine(String.Join(", ", orderedEvenNums));
        }

    }
}


