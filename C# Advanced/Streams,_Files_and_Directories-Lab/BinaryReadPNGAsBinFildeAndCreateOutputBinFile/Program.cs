using System;
using System.IO;
using System.Text;

namespace BinaryReadPNGAsBinFildeAndCreateOutputBinFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string binaryFilePath = @"../../../Files/example.png";
            string bytesFilePath = @"../../../Files/bytes.txt"; // не прави нищо
            string outputPath = @"../../../Files/output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            FileStream fin = new FileStream(binaryFilePath, FileMode.Open);
            using (fin)
            {
                using (BinaryReader reader = new BinaryReader(fin, Encoding.Default))
                {
                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        int bytesRead = reader.Read(buffer, 0, buffer.Length);
                        if (bytesRead == 0) break;

                        FileStream fout = new FileStream(outputPath, FileMode.Create);
                        using (fout)
                        {
                            fout.Write(buffer, 0, bytesRead);

                        }

                    }
                }

            }

        }
    }
}
