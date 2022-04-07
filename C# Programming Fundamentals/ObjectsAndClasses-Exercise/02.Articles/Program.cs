using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Articles
{

    class Article
    {
        public Article()
        {

        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public void Edit(string content)
        {
            this.Content = content;
        }

        public void ChangeAuthor(string author)
        {
            this.Author = author;
        }

        public void Rename(string title)
        {
            this.Title = title;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] articleInput = Console.ReadLine().Split(", ");
            Article article = new Article()
            {
                Title = articleInput[0],
                Content = articleInput[1],
                Author = articleInput[2]
            };

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split(": ");
                switch (commands[0])
                {
                    case "Edit":
                        article.Edit(commands[1]);
                        break;

                    case "ChangeAuthor":
                        article.ChangeAuthor(commands[1]);
                        break;

                    case "Rename":
                        article.Rename(commands[1]);
                        break;
                }
            }

            Console.WriteLine(article);
        }
    }
}

