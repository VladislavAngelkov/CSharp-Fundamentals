using System;
using System.Numerics;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = FactorielDivision(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine($"{result:f2}");
        }
        public static double FactorielDivision(int firstNumber, int secondNumber)
        {
            BigInteger firstFactoriel = 1;
            BigInteger secondFactoriel = 1;
            for (int i = 1; i <= firstNumber; i++)
            {
                firstFactoriel *= i;
            }
            if (firstNumber == 0)
            {
                firstFactoriel = 0;
            }
            for (int i = 1; i <= secondNumber; i++)
            {
                secondFactoriel *= i;
            }
            if (secondNumber == 0)
            {
                secondFactoriel = 0;
            }
            double result = (double)firstFactoriel / (double)secondFactoriel;
            return result;
        }
    }
}
