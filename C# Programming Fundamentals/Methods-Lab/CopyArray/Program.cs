using System;

namespace CopyArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = { 1 };
            int[] secondArray = new int [firstArray.Length];
            Array.Copy(firstArray, secondArray, firstArray.Length);

        }
    }
}

