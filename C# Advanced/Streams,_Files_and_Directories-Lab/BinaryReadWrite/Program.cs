using System;
using System.IO;
using System.Text;

namespace BinaryReadWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //https://www.bestprog.net/en/2021/02/18/c-classes-binaryreader-and-binarywriter-examples-of-solving-tasks/
                // Write the following data to the file2.bin file:
                // - number of double type;
                // - a string of type string;
                // - character of type char;
                // - number of sbyte type.

                // 1. Writing numbers
                using (FileStream fs = new FileStream("../../../Files/file2.bin",
          FileMode.Create))
                {
                    using (BinaryWriter bw = new BinaryWriter(fs, Encoding.Default))
                    {
                        // 1.2. Original numbers
                        double x = 3.88;
                        string s = "Hello world!";
                        char c = 'Z';
                        sbyte b = 17;

                        // 1.3. Write numbers - Write() method
                        bw.Write(x);
                        bw.Write(s);
                        bw.Write(c);
                        bw.Write(b);
                    }
                }

                // 2. Reading numbers
                using (FileStream fs = new FileStream("../../../Files/file2.bin",
          FileMode.Open))
                {
                    using (BinaryReader br = new BinaryReader(fs, Encoding.Default))
                    {
                        // 2.1. Variables, in which data is read
                        double x2;
                        string s2;
                        char c2;
                        sbyte b2;

                        // 2.2. Reading data
                        x2 = br.ReadDouble();
                        s2 = br.ReadString();
                        c2 = br.ReadChar();
                        b2 = br.ReadSByte();

                        // 2.3. Display the result
                        Console.WriteLine("x2 = {0}", x2);
                        Console.WriteLine("s2 = {0}", s2);
                        Console.WriteLine("c2 = {0}", c2);
                        Console.WriteLine("b2 = {0}", b2);
                    }
                }
            }
        }
    }
}
