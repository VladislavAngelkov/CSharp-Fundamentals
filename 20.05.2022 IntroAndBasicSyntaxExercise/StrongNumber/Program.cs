using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int workNumber = number;
            int sum = 0;
            int rest = 0;
            int digit = 0;
            int digitFactoriel = 1;
            while (workNumber != 0)
            {
                digit = workNumber % 10;
                for (int i = 1; i <= digit; i++)
                {
                    digitFactoriel *= i;
                }
                sum += digitFactoriel;
                workNumber /= 10;
                digitFactoriel = 1;
            }
            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
