using System;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numbersCount; i++)
            {
                int sum = 0;
                int number = i;
                while (number > 0)
                {
                    sum += number % 10;
                    number = number / 10;
                }
                 bool isSpecial = ((sum == 5) || (sum == 7) || (sum == 11));
                Console.WriteLine($"{i} -> {isSpecial}");
            }

        }
    }
}
