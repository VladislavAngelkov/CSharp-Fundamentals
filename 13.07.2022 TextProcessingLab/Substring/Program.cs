using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string substring = Console.ReadLine();

            string text = Console.ReadLine();

            while (text.Contains(substring))
            {
                int startingIndex = text.IndexOf(substring);

                int lenght = substring.Length;

                text = text.Remove(startingIndex, lenght);
            }

            Console.WriteLine(text);
        }
    }
}
