using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MiddleCharacters(Console.ReadLine()));
        }
        public static string MiddleCharacters(string text)
        {
            string result = "";
            if (text.Length%2==0)
            {
                result = text[text.Length / 2 - 1].ToString() + text[text.Length / 2].ToString();
            }
            else
            {
                result = text[text.Length / 2].ToString();
            }
            return result;
        }
    }
}
