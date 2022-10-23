using System;

namespace LetterChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double result = 0;

            foreach (var item in input)
            {
                char firstLetter = item[0];
                char lastLetter = item[item.Length - 1];
                double number = double.Parse(item.Substring(1, item.Length - 2));

                double currentResult = number;

                int letterPosition = 0;

                if (char.IsUpper(firstLetter))
                {
                    letterPosition = firstLetter - 64;
                    currentResult /= letterPosition;
                }
                else
                {
                    letterPosition = firstLetter - 96;
                    currentResult *= letterPosition;
                }

                if (char.IsUpper(lastLetter))
                {
                    letterPosition = lastLetter - 64;
                    currentResult -= letterPosition;
                }
                else
                {
                    letterPosition = lastLetter - 96;
                    currentResult += letterPosition;
                }

                result += currentResult;
            }

            Console.WriteLine($"{result:f2}");
        }
    }
}
