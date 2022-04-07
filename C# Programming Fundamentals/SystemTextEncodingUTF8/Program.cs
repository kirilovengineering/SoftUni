using System;

namespace SystemTextEncodingUTF8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            char ch = '\u00B1';
            Console.WriteLine(ch);//This is +-

        }
    }
}
