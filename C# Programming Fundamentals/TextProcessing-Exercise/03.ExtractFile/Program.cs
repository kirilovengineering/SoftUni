using System;

namespace _03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] directory = Console.ReadLine().Split('\\');// за стинг може (@"\") или ("\\")
            int n = directory.Length;
            string fileAndExtensioString = directory[n - 1];
            string[] fileAndExtensionArray = fileAndExtensioString.Split('.');

            Console.WriteLine($"File name: {fileAndExtensionArray[0]}");
            Console.WriteLine($"File extension: {fileAndExtensionArray[1]}");
        }
    }
}
