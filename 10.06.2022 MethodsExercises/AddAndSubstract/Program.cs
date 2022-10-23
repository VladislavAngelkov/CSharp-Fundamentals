using System;

namespace AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SubstractIntegers(AddIntegers(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())), int.Parse(Console.ReadLine())));
        }
        public static int AddIntegers(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }
        public static int SubstractIntegers(int firstNumber, int secondNumber)
        {
            int result = firstNumber - secondNumber;
            return result;
        }
    }
}
