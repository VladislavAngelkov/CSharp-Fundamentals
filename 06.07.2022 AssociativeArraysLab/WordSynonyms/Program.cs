using System;
using System.Collections.Generic;

namespace WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWordsPair = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < numberOfWordsPair; i++)
            {
                string word = Console.ReadLine();

                if (!synonyms.ContainsKey(word))
                {
                    List<string> words = new List<string>();

                    synonyms.Add(word, words);
                }

                synonyms[word].Add(Console.ReadLine());
            }

            foreach (var wordAndSynonyms in synonyms)
            {
                Console.WriteLine($"{wordAndSynonyms.Key} - {string.Join(", ", wordAndSynonyms.Value)}");
            }
        }
    }
}
