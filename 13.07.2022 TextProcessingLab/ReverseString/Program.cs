using System;
using System.Linq;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            while (text != "end")
            {
                string reversedText = "";

                for (int i = text.Length-1; i >= 0; i--)
                {
                    reversedText += text[i].ToString();
                }

                Console.WriteLine($"{text} = {reversedText}");

                text = Console.ReadLine();
            }
        }
    }
}
