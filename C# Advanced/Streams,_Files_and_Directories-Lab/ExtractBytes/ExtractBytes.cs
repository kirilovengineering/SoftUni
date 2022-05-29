namespace ExtractBytes
{
    using System;
    using System.Collections.Generic;
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
                    List<byte> temp = new List<byte>();
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


                        for (int i = 0; i < buffer.Length; i++)
                        {
                            for (int j = 0; j < searchBytesBytes.Length; j++)
                            {
                                if (searchBytesBytes[j] == buffer[i])
                                {
                                    temp.Add(searchBytesBytes[j]);
                              
                                    //int indexToRemove = i;
                                    //searchBytesBytes = searchBytesBytes.Where((source, index) => index != indexToRemove).ToArray();
                                }
                            }
                        }
                        var tempBuffer = new byte[temp.Count];
                        for (int i = 0; i < temp.Count; i++)
                        {
                            tempBuffer[i] = temp[i];
                        }
                        //tempBuffer = temp.ToArray();
                        //Презаписва файла с цялото съдържание
                        FileStream fout = new FileStream(outputPath, FileMode.Create);
                        using (fout)
                        {
                            fout.Write(tempBuffer, 0, temp.Count);
                        }
                    }
                }

            }

        }
    }
}


//namespace ExtractBytes
//{
//    using System;
//    using System.IO;
//    using System.Linq;
//    using System.Text;

//    public class ExtractBytes
//    {
//        static void Main(string[] args)
//        {
//            const string binaryFilePath = @"..\..\..\Files\example.png";
//            const string bytesFilePath = @"..\..\..\Files\bytes.txt";
//            const string outputPath = @"..\..\..\Files\output.bin";

//            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
//        }

//        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
//        {
//            StringBuilder sb = new StringBuilder();
//            using (StreamReader readerBit = new StreamReader(bytesFilePath))
//            {
//                while (!readerBit.EndOfStream)
//                {
//                    sb.Append(readerBit.ReadLine() + " ");
//                }
//            }

//            byte[] bytes = sb.ToString().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(byte.Parse).ToArray();


//            using (FileStream reader = new FileStream(binaryFilePath, FileMode.Open))
//            {
//                byte[] buff = new byte[reader.Length];

//                reader.Read(buff, 0, buff.Length);

//                using (FileStream write = new FileStream(outputPath, FileMode.OpenOrCreate))
//                {
//                    foreach (byte item in buff)
//                    {
//                        if (bytes.Contains(item))
//                        {
//                            write.WriteByte(item);
//                        }
//                    }
//                }
//            }// using (FileStream reader = new FileStream(inputFileName, FileMode.Open)
//        }// void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
//    }
//}