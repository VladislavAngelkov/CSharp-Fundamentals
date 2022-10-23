using System;
using System.Linq;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(VowelsCount(Console.ReadLine()));
        }
        public static int VowelsCount(string text)
        {
            char[] vowels = new char[] { 'a', 'o', 'e', 'i', 'u', 'A', 'O', 'E', 'I', 'U' };
            int vowelsSum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (vowels.Contains(text[i]))
                {
                    vowelsSum++;
                }
            }
            return vowelsSum;
        }
    }
}
