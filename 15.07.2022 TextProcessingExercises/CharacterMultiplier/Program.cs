using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();

            string firstString = text[0];
            string secondString = text[1];

            int result = Multiply(firstString, secondString);

            Console.WriteLine(result);
        }

        private static int Multiply(string firstString, string secondString)
        {
            string biggerString = "";
            string smallerString = "";

            if (firstString.Length>secondString.Length)
            {
                biggerString = firstString;
                smallerString = secondString;
            }
            else
            {
                biggerString = secondString;
                smallerString = firstString;
            }

            int result = 0;

            for (int i = 0; i < smallerString.Length; i++)
            {
                result += biggerString[i] * smallerString[i];
            }

            if (biggerString.Length!=smallerString.Length)
            {
                for (int i = smallerString.Length; i < biggerString.Length; i++)
                {
                    result += biggerString[i];
                }
            }

            return result;
        }
    }
}
