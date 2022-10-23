using System;
using System.Collections.Generic;

namespace CountCharsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Dictionary<string, int> charOcurrences = new Dictionary<string, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]!=' ')
                {
                    if (!charOcurrences.ContainsKey(text[i].ToString()))
                    {
                        charOcurrences.Add(text[i].ToString(), 0);
                    }

                    charOcurrences[text[i].ToString()]++;
                }
            }

            foreach (var character in charOcurrences)
            {
                Console.WriteLine($"{character.Key} -> {character.Value}");
            }
        }
    }
}
