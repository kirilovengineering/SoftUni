namespace LineNumbers
{
    using System.IO;
    public class LineNumbers
    {
        static void Main(string[] args)
        {
            string inputPath = @"../../../Files/input.txt"; // дясната черта(която си е линукска) работи и на уидоус
            string outputPath = @"../../../Files/output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            StreamReader reader = new StreamReader(inputFilePath);
            using (reader)
            {
                var writer = new StreamWriter(outputFilePath);
                using (writer)
                {
                    int lineNum = 1;
                    string line = string.Empty;
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(lineNum + ". " + line);
                        lineNum++;
                    }
                }
            }
        }
    }
}
