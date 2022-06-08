using System;

namespace _02.ArrayCreator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] strings = ArrayCreator.Create(5, "Pesho");
            int[] integers = ArrayCreator.Create(10, 33);

            for (int i = 0; i < strings.Length; i++)
                Console.WriteLine(strings[i]);

            for (int i = 0; i < integers.Length; i++)
                Console.WriteLine(integers[i]);


        }
    }
}
