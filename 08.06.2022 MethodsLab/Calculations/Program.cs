using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate(Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
        }
        public static int Calculate(string action, int firstNumber, int secondNumber)
        {
            int result = 0;
            if (action == "add")
            {
                result = firstNumber + secondNumber;
            }
            else if (action == "multiply")
            {
                result = firstNumber * secondNumber;
            }
            else if (action == "subtract")
            {
                result = firstNumber - secondNumber;
            }
            else if (action == "divide")
            {
                result = firstNumber / secondNumber;
            }
            return result;
        }
    }
}
