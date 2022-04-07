using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Articles2._0
{

    class Article
    {

        public Article()
        {

        }


        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }


        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] articleInput = Console.ReadLine().Split(", ");
                Article article = new Article()
                {
                    Title = articleInput[0],
                    Content = articleInput[1],
                    Author = articleInput[2]
                };

                articles.Add(article);
            }

            string criteria = Console.ReadLine();
            switch (criteria)
            {
                case "title":
                    articles = articles.OrderBy(a => a.Title).ToList();
                    break;

                case "content":
                    articles = articles.OrderBy(a => a.Content).ToList();
                    break;

                case "author":
                    articles = articles.OrderBy(a => a.Author).ToList();
                    break;
            }

            foreach (Article article in articles)
            {
                Console.WriteLine(article);
            }
        }
    }
}