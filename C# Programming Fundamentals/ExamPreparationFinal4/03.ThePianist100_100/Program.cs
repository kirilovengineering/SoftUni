using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.ThePianist_2
{
    class PianoPiece
    {
        public PianoPiece(string piece, string composer, string key)
        {
            this.Piece = piece;
            this.Composer = composer;
            this.Key = key;
        }
        public string Piece;
        public string Composer;
        public string Key;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<PianoPiece> pianoPieces = new List<PianoPiece>();
            for (int i = 0; i < number; i++)
            {
                string[] token = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);
                string piece = token[0];
                string composer = token[1];
                string key = token[2];
                PianoPiece currentPianoPiece = new PianoPiece(piece, composer, key);
                pianoPieces.Add(currentPianoPiece);

            }
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] token = command.Split('|', StringSplitOptions.RemoveEmptyEntries);
                switch (token[0])
                {
                    case "Add":
                        AddPiece(pianoPieces, token);
                        break;

                    case "Remove":
                        RemovePiece(pianoPieces, token);
                        break;

                    case "ChangeKey":
                        ChangeKey(pianoPieces, token);
                        break;
                    default:
                        break;
                }

            }
            PrintResult(pianoPieces);
        }
        public static void AddPiece(List<PianoPiece> pianoPieces, string[] token)
        {
            string piece = token[1];
            string composer = token[2];
            string key = token[3];
            PianoPiece currentPianoPiece = new PianoPiece(piece, composer, key);
            if (pianoPieces.FirstOrDefault(x => x.Piece == piece) == null)
            {
                pianoPieces.Add(currentPianoPiece);
                Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
            }
            else
            {
                Console.WriteLine($"{piece} is already in the collection!");
            }

        }
        public static void RemovePiece(List<PianoPiece> pianoPieces, string[] token)
        {
            string piece = token[1];
            var itemToremove = pianoPieces.FirstOrDefault(x => x.Piece == piece);
            if (itemToremove != null)
            {
                pianoPieces.Remove(itemToremove);
                Console.WriteLine($"Successfully removed {piece}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
            }

        }
        public static void ChangeKey(List<PianoPiece> pianoPieces, string[] token)
        {
            string piece = token[1];
            string key = token[2];
            var itemToChangeKey = pianoPieces.FirstOrDefault(x => x.Piece == piece);
            if (itemToChangeKey != null)
            {
                itemToChangeKey.Key = key;
                //pianoPieces.FirstOrDefault(x => x.Piece == piece).Key = key;
                Console.WriteLine($"Changed the key of {piece} to {key}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
            }

        }
        public static void PrintResult(List<PianoPiece> pianoPieces)
        {
            foreach (var item in pianoPieces)
            {
                Console.WriteLine($"{item.Piece} -> Composer: {item.Composer}, Key: {item.Key}");
            }

        }
    }

}
