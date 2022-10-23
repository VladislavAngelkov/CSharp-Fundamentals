using System;
using System.Numerics;

namespace BigFactoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int factoriel = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            for (int i = 1; i <= factoriel; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}
