using System;
using System.IO;

namespace _03.CopyBinaryFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            //1. reader -> прочитаме input file
            using (FileStream reader = new FileStream(inputFilePath, FileMode.Open))
            {
                //2. writer -> копира в outputfile
                using (FileStream writer = new FileStream(outputFilePath, FileMode.Create))
                {
                    while (true)
                    {
                        byte[] buffer = new byte[4096];
                        int countBytes = reader.Read(buffer, 0, buffer.Length);
                        if (countBytes == 0) //нямаме данни във файла
                        {
                            break; //прекратяваме четенето файла
                        }


                        writer.Write(buffer, 0, countBytes);
                    }
                }
            }
        }
    }
}
