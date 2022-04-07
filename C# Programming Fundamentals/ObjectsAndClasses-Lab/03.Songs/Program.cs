using System;
using System.Collections.Generic;

namespace _03.Songs
{
    class Song
    {
        public string TypeList { get; set; }

        public string Name { get; set; } 

        public string Time { get; set; }
    }
    
    
    
    class Program
    {
        static void Main(string[] args)
        {
            int nuberOfSongs = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < nuberOfSongs; i++)
            {
                string[] lineParams = Console.ReadLine().Split('_', StringSplitOptions.RemoveEmptyEntries);

                Song song = new Song()
                { 
                    TypeList = lineParams[0],
                    Name = lineParams[1],
                    Time = lineParams[2]
                };
                songs.Add(song);
            }

            string filterValue = Console.ReadLine();

            if (filterValue == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                var filteredSongs = songs.FindAll(x => x.TypeList == filterValue);

                foreach (var song in filteredSongs)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
}
