using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(" ").ToList();
            List<string> randomizedWords = new List<string>();
            Random random = new Random();
            for (int i = 0; i < words.Count; i++)
            {
                string changeWord = words[i];
                int index = random.Next(0, words.Count);
                words[i] = words[index];
                words[index] = changeWord;
            }
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
