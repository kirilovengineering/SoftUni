using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Food_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] consonants = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            Queue<char> vovelsCollection = new Queue<char>(vowels);
            Stack<char> consonantsCollection = new Stack<char>(consonants);

            HashSet<string> words = new HashSet<string>();

            string pearStringStart = "pear";
            string flourStringStart = "flour";
            string porkStringStart = "pork";
            string oliveStringStart = "olive";

            string pearString = "pear";
            string flourString = "flour";
            string porkString = "pork";
            string oliveString = "olive";


            int numberOfWordsFound = 0;

            while (consonantsCollection.Count > 0)
            {
                var tv = vovelsCollection.Peek();
                bool pearV = "pear".Contains(tv);
                bool flourV = "flour".Contains(tv);
                bool porkV = "pork".Contains(tv);
                bool oliveV = "olive".Contains(tv);
                string tvs = tv.ToString();
                if (pearV) { pearString = pearString.Replace(tvs, ""); }
                if (flourV) { flourString = flourString.Replace(tvs, ""); }
                if (porkV) { porkString = porkString.Replace(tvs, ""); }
                if (oliveV) { oliveString = oliveString.Replace(tvs, ""); }

                vovelsCollection.Dequeue();
                vovelsCollection.Enqueue(tv);

                var tc = consonantsCollection.Peek();

                bool pearC = "pear".Contains(tc);
                bool flourC = "flour".Contains(tc);
                bool porkC = "pork".Contains(tc);
                bool oliveC = "olive".Contains(tc);
                string tcs = tc.ToString();
                if (pearC) { pearString = pearString.Replace(tcs, ""); }
                if (flourC) { flourString = flourString.Replace(tcs, ""); }
                if (porkC) { porkString = porkString.Replace(tcs, ""); }
                if (oliveC) { oliveString = oliveString.Replace(tcs, ""); }

                consonantsCollection.Pop();

                if (pearString.Length <= 0) { words.Add(pearStringStart); }
                if (flourString.Length <= 0) { words.Add(flourStringStart); }
                if (porkString.Length <= 0) { words.Add(porkStringStart); }
                if (oliveString.Length <= 0) { words.Add(oliveStringStart); }

            }
            numberOfWordsFound = words.Count;

            Console.WriteLine($"Words found: {numberOfWordsFound}");
            if (words.Contains("pear")) { Console.WriteLine("pear"); }
            if (words.Contains("flour")) { Console.WriteLine("flour"); }
            if (words.Contains("pork")) { Console.WriteLine("pork"); }
            if (words.Contains("olive")) { Console.WriteLine("olive"); }

        }
    }
}
