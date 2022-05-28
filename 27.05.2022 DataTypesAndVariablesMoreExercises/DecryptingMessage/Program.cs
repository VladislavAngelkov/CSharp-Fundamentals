using System;

namespace DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numberOfLines = int.Parse(Console.ReadLine());
            string message = "";
            for (int i = 0; i < numberOfLines; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                message += ((char)(currentChar + key)).ToString();
            }
            Console.WriteLine(message);
        }
    }
}
