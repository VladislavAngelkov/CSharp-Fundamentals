using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CharactersInRange(char.Parse(Console.ReadLine()), char.Parse(Console.ReadLine())));
        }
        public static string CharactersInRange(char firstChar, char secondChar)
        {
            string result = "";
            if (firstChar>secondChar)
            {
                for (int i = (char)(secondChar+1); i < firstChar; i++)
                {
                    result += (char)i + " ";
                }
            }
            else
            {
                for (int i = (char)(firstChar+1); i < secondChar; i++)
                {
                    result += (char)i + " ";
                }
            }
            return result;
        }
    }
}
