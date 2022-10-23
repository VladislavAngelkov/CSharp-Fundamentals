using System;
using System.Linq;
using System.Text;

namespace TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string codedMessage = Console.ReadLine();

            while (codedMessage!="find")
            {
                StringBuilder message = new StringBuilder();

                for (int i = 0; i < codedMessage.Length; i++)
                {
                    int keyIndex = i % key.Length;

                    char decodedChar = (char)(codedMessage[i] - key[keyIndex]);

                    message.Append(decodedChar);
                }

                string stringMesssage = message.ToString();

                string treasureSubstring = stringMesssage.Substring(stringMesssage.IndexOf('&')+1);
                string treasure = treasureSubstring.Substring(0, treasureSubstring.IndexOf('&'));

                string coordenates = stringMesssage.Substring(stringMesssage.IndexOf('<') + 1, stringMesssage.IndexOf('>') - stringMesssage.IndexOf('<') - 1);

                Console.WriteLine($"Found {treasure} at {coordenates}");

                codedMessage = Console.ReadLine();
            }
        }
    }
}
