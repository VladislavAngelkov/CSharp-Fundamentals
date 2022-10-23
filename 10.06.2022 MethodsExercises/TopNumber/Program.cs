using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            TopNumber(int.Parse(Console.ReadLine()));
        }

        static void TopNumber(int endNumber)
        {
            bool isPositive = true;
            if (endNumber < 0)
            {
                isPositive = false;
            }
            for (int i = 1; i < Math.Abs(endNumber); i++)
            {
                int number = i;
                int sumOfDigits = 0;
                bool isTopNumber = false;
                while (number != 0)
                {
                    int lastDigit = number % 10;
                    number /= 10;
                    sumOfDigits += lastDigit;
                    if (lastDigit % 2 == 1)
                    {
                        isTopNumber = true;
                    }
                }
                if (isTopNumber)
                {
                    if (sumOfDigits%8!=0)
                    {
                        isTopNumber = false;
                    }
                }
                if (isTopNumber)
                {
                    if (isPositive)
                    {
                        Console.WriteLine(i);
                    }
                    else
                    {
                        Console.WriteLine($"{-i}");
                    }
                }
            }
        }
    }
}
