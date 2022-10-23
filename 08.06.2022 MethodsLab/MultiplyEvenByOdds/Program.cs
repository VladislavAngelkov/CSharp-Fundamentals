using System;

namespace MultiplyEvenByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMultipleOfEvenAndOdds(int.Parse(Console.ReadLine())));
        }
        public static int GetMultipleOfEvenAndOdds(int number)
        {
            int evenSum = 0;
            int oddSum = 0;
            number = Math.Abs(number);
            while (number!=0)
            {
                int lastDigit = number % 10;
                number = number / 10;
                if (lastDigit%2==0)
                {
                    evenSum += lastDigit;
                }
                else
                {
                    oddSum += lastDigit;
                }
            }
            int result = evenSum * oddSum;
            return result;
        }
    }
}
