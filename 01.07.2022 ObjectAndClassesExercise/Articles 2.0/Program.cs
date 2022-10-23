using System;
using System.Collections.Generic;

namespace Articles
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void Rename(string newName)
        {
            this.Title = newName;
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
        
            int numberOfArticles = int.Parse(Console.ReadLine());

            List <Article> articles = new List<Article>();

            for (int i = 0; i < numberOfArticles; i++)
            {
                string[] articleInfo = Console.ReadLine().Split(", ");

                Article article = new Article(articleInfo[0], articleInfo[1], articleInfo[2]);

                articles.Add(article);
            }

            foreach (var article in articles)
            {
                Console.WriteLine(article);
            }

        }
    }
}

