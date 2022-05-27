namespace ExtractBytes
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class ExtractBytes
    {
        static void Main(string[] args)
        {
            string binaryFilePath = @"../../../Files/example.png";
            string bytesFilePath = @"../../../Files/bytes.txt";
            string outputPath = @"../../../Files/output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {

            FileStream fin = new FileStream(binaryFilePath, FileMode.Open);//рзширен запис на юзинг
            using (fin)
            {
                using (BinaryReader reader = new BinaryReader(fin, Encoding.Default))//съкратен запис на юзинг
                {
                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        int bytesRead = reader.Read(buffer, 0, buffer.Length);
                        if (bytesRead == 0) break;


                        string[] searchBytesString = File.ReadAllLines(bytesFilePath);

                        int[] searchBytesInts = new int[searchBytesString.Length];
                        for (int i = 0; i < searchBytesInts.Length; i++)
                        {
                            searchBytesInts[i] = int.Parse(searchBytesString[i]);
                        }

                        byte[] searchBytesBytes = new byte[searchBytesInts.Length];
                        for (int i = 0; i < searchBytesBytes.Length; i++)
                        {
                            searchBytesBytes[i] = (byte)searchBytesInts[i];
                        }

                        for (int i = 0; i < searchBytesBytes.Length; i++)
                        {
                            searchBytesBytes[i] = (byte)searchBytesInts[i];
                        }

                        for (int i = 0; i < buffer.Length; i++)
                        {
                            for (int j = 0; j < searchBytesBytes.Length; j++)
                            {
                                if (searchBytesBytes[j] != buffer[i])
                                {
                                    int indexToRemove = i;
                                    searchBytesBytes = searchBytesBytes.Where((source, index) => index != indexToRemove).ToArray();
                                }
                            }
                        }

                        //Презаписва файла с цялото съдържание
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
