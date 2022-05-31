using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Predicate<string> isUpperFirstLetter = 
        //        (string x) => x.Length > 0 && char.IsUpper(x[0]);
        //    Console.WriteLine(
        //        String.Join(
        //            "\r\n", //5. Рзпечатваме на конзола разделени по нов ред
        //            Console.ReadLine() // 1. Четем от конзола
        //            .Split(" ") // 2. Рзделените думи от конзолния стринг по интервал
        //            .Where(x => isUpperFirstLetter(x)) //3. Където са думи започващи с главна буква
        //            .ToArray() // 4. Към масив естествено.
        //            )           
        //        );
        //}

        // Типичен пример за функционално програмиране
        static void Main() =>
            Console.WriteLine(
                String.Join(
                    "\r\n", //5. Рзпечатваме на конзола разделени по нов ред
                    Console.ReadLine() // 1. Четем от конзола
                    .Split(" ") // 2. Рзделените думи от конзолния стринг по интервал
                    .Where(x => x.Length > 0 && char.IsUpper(x[0])) //3. Където са думи започващи с главна буква
                    .ToArray() // 4. Към масив естествено.
                    )
                );


    }
}
