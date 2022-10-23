using System;
using System.Collections.Generic;
using System.Linq;

namespace WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ");

            Dictionary<string, int> wordsAndLenghts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!wordsAndLenghts.ContainsKey(word))
                {
                    wordsAndLenghts.Add(word, word.Length);
                }
            }

            foreach (var word in wordsAndLenghts.Where(x => x.Value % 2 == 0))
            {
                Console.WriteLine(word.Key);
            }
        }
    }
}
