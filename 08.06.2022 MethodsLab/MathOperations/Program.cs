using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculation(double.Parse(Console.ReadLine()), char.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
        }
        public static double Calculation(double firstNumber, char mathOperator, double secondNumber)
        {
            double result = 0;
            switch (mathOperator)
            {
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                case '/':
                    result = firstNumber / secondNumber;
                    break;
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
            }
            return result;
        }
    }
}
