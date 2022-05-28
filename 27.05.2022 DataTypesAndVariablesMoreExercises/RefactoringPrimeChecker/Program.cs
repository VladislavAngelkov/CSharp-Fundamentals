using System;

namespace RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());
            for (int currentNumber = 2; currentNumber <= endNumber; currentNumber++)
            {
                bool isPrime = true;
                for (int divider = 2; divider < currentNumber; divider++)
                {
                    if (currentNumber % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{currentNumber} -> {isPrime.ToString().ToLower()}");
            }

        }
    }
}
