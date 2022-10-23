using System;

namespace Experiments
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "lloHe";
            int numberOfLetters = 3;
            string substring = text.Substring(0, numberOfLetters);
            text = text.Remove(0, numberOfLetters);
            text = text.Insert(text.Length - 1, substring);

            Console.WriteLine(text);
        }
    }
}
