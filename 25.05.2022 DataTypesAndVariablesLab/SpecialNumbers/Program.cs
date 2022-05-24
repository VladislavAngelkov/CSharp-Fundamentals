using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumbersCount = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= NumbersCount; i++)
            {
                int number = i;
                while (number>0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
                sum = 0;
            }
        }
    }
}
