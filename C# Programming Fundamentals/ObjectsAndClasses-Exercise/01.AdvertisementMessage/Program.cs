using System;

namespace _01.AdvertisementMessage
{

    public class AdvertisementMessage
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
                string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
                string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
                string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

                string[] message = new string[4];

                int numberOfMessages = int.Parse(Console.ReadLine());

                Random random = new Random();

                for (int i = 0; i < numberOfMessages; i++)
                {
                    int randomIndexPhrases = random.Next(0, phrases.Length - i);
                    int randomIndexEvents = random.Next(0, events.Length - i);
                    int randomIndexAuthors = random.Next(0, authors.Length - i);
                    int randomIndexCities = random.Next(0, cities.Length - i);

                    message[0] = phrases[randomIndexPhrases];
                    message[1] = events[randomIndexEvents];
                    message[2] = authors[randomIndexAuthors];
                    message[3] = cities[randomIndexCities];

                    Console.WriteLine($"{message[0]} {message[1]} {message[2]} – {message[3]}.");
                }
            }
        }
    }
}
