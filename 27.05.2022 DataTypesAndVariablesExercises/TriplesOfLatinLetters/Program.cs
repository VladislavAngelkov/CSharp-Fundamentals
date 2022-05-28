using System;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int letterCount = int.Parse(Console.ReadLine());
            string letterCombination = "";
            for (int i = 'a'; i < letterCount + 'a'; i++)
            {
                for (int j = 'a'; j < letterCount + 'a'; j++)
                {
                    for (int k = 'a'; k < letterCount + 'a'; k++)
                    {
                        letterCombination = ((char)i).ToString() + ((char)j).ToString() + ((char)k).ToString();
                        Console.WriteLine(letterCombination);
                    }
                }
            }
        }
    }
}
