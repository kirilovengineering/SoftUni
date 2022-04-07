using System;

namespace InspectLoopForToAndAfterArary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Valid record in C# dinamicly length in array
            int[] nums = new int[n];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    //Elements befor current index i;
                }

                for (int j = i; j < nums.Length; j++)
                {
                    //Elements after current index i;
                }
            }
        }
    }
}
