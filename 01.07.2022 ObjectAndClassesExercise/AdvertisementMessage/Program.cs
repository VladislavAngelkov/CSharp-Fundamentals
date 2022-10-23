using System;
using System.Collections.Generic;

namespace AdvertisementMessage
{
    class Phrases
    {
        public string Phrase 
        {
            get
            {
                List<string> text = new List<string>{ "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product."};

                Random rnd = new Random();

                return text[rnd.Next(0, text.Count)];
            }
        }
    }

    class Events
    {
        public string Event
        {
            get
            {
                List<string> text = new List<string> { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };

                Random rnd = new Random();

                return text[rnd.Next(0, text.Count)];
            }
        }
    }

    class Authors
    {
        public string Author
        {
            get
            {
                List<string> text = new List<string> { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

                Random rnd = new Random();

                return text[rnd.Next(0, text.Count)];
            }
        }
    }

    class Cities
    {
        public string City
        {
            get
            {
                List<string> text = new List<string> { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

                Random rnd = new Random();

                return text[rnd.Next(0, text.Count)];
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMessages = int.Parse(Console.ReadLine());

            Phrases phrase = new Phrases();
            Events eventAddvertisement = new Events();
            Authors author = new Authors();
            Cities city = new Cities();

            for (int i = 0; i < numberOfMessages; i++)
            {
                Console.WriteLine($"{phrase.Phrase} {eventAddvertisement.Event} {author.Author} – {city.City}.");
            }
        }
    }
}
