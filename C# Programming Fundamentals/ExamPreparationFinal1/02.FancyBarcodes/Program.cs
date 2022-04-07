using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.FancyBarcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex patttern = new Regex(@"@#+[A-Z][A-Za-z\d]{4,}[A-Z]@#+");
            int barcodeCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < barcodeCount; i++)
            {
                string barcode = Console.ReadLine();

                if (patttern.IsMatch(barcode))
                {
                    char[] digits = barcode.Where(x => char.IsDigit(x)).ToArray();

                    if (digits.Length == 0)
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {string.Join("", digits)}");
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid barcode");
                }
            }
        }
    }
}