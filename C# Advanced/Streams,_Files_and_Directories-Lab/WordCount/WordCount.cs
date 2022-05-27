namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class WordCount
    {
        static void Main(string[] args)
        {
            string wordPath = @"../../../Files/words.txt";
            string textPath = @"../../../Files/text.txt";
            string outputPath = @"../../../Files/output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            StreamReader wordReader = new StreamReader(wordsFilePath);
            using (wordReader)
            {
                string[] wordsToCount = wordReader.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(word => word.ToLower()).ToArray();
                //гарантираме че думите които търсим с неповторими за търсене
                HashSet<string> wordsUnique = new HashSet<string>();
                for (int i = 0; i < wordsToCount.Length; i++)
                {
                    wordsUnique.Add(wordsToCount[i]);
                }
                // инициализиране

                foreach (var item in wordsUnique)
                {
                    if (!wordsCount.ContainsKey(item))
                    {
                        {
                            wordsCount[item] = 0;
                        }
                    }
                }

            };

            //по добър код :) ...
            //HashSet<string> wordsUnique = wordReader.ReadToEnd()
            //                  .Split(new string[] { " ", "\t", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
            //                  .Select(word => word.ToLower())
            //                  .ToHashSet();
            //foreach (string word in wordsUnique)
            //{
            //    if (!wordsCount.ContainsKey(word))
            //    {
            //        wordsCount[word] = 0;
            //    }
            //}


            StreamReader text = new StreamReader(textFilePath);
            using (text)
            {
                string[] textWords = text.ReadToEnd()
                                            .Split(new string[] { " ", "\t", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                                            .Select(word => Regex.Match(word, @"[A-Za-z']*[A-Za-z]{1}").Value.ToLower())
                                            .ToArray();

                foreach (var item in textWords)
                {
                    if (wordsCount.ContainsKey(item))
                    {
                        wordsCount[item]++;
                    }
                }
            }

            StreamWriter writerOutput = new StreamWriter(outputFilePath);
            using (writerOutput)
            {
                foreach (var item in wordsCount.OrderByDescending(w => w.Value))
                {
                    writerOutput.WriteLine($"{item.Key} - {item.Value}");
                }
            }

        }
    }
}
