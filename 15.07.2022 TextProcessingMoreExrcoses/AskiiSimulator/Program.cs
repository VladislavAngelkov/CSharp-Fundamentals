using System;

namespace AskiiSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            if ((int)secondChar<(int)firstChar)
            {
                char temp = secondChar;
                secondChar = firstChar;
                firstChar = temp;
            }

            string text = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if ((int)text[i]>(int)firstChar && (int)text[i]<(int)secondChar)
                {
                    sum += (int)text[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
