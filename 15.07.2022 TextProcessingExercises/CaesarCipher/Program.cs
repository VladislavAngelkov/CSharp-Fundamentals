using System;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        public static object StrigBuilder { get; private set; }

        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder encryptedText = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                encryptedText.Append((char)(text[i]+3));
            }

            Console.WriteLine(encryptedText);
        }
    }
}
