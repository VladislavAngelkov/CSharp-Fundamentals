using System;
using System.Collections.Generic;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ");

            Dictionary<string, int> wordsOcurrences = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (!wordsOcurrences.ContainsKey(words[i].ToLower()))
                {
                    wordsOcurrences.Add(words[i].ToLower(), 0);
                }

                wordsOcurrences[words[i].ToLower()]++;
            }

            foreach (var word in wordsOcurrences)
            {
                if (word.Value%2==1)
                {
                    Console.Write($"{word.Key} ");
                }
            }
        }
    }
}
