using System;

namespace RepeatingString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RepeatString(Console.ReadLine(), int.Parse(Console.ReadLine())));
        }
        public static string RepeatString(string text, int repeatCount)
        {
            string result = "";
            for (int i = 0; i < repeatCount; i++)
            {
                result += text;
            }
            return result;
        }
    }
}
