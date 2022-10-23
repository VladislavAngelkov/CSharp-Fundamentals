using System;

namespace MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            MultiplicationSign(firstNumber, secondNumber, thirdNumber);
        }

        static void MultiplicationSign(int firstNumber, int secondNumber, int thirdNumber)
        {
            int negativeCount = 0;
            bool isZero = false;
            if (firstNumber<0)
            {
                negativeCount++;
            }
            else if (firstNumber == 0)
            {
                isZero = true;
            }

            if (secondNumber < 0)
            {
                negativeCount++;
            }
            else if (secondNumber == 0)
            {
                isZero = true;
            }

            if (thirdNumber < 0)
            {
                negativeCount++;
            }
            else if (thirdNumber == 0)
            {
                isZero = true;
            }

            if (isZero)
            {
                Console.WriteLine("zero");
            }
            else if (negativeCount == 1 || negativeCount == 3)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }
        }
    }
}
