using System;

namespace FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double firstNumber = Math.Abs(Math.Truncate(double.Parse(Console.ReadLine())*1000000));
            double secondNumber = Math.Abs(Math.Truncate(double.Parse(Console.ReadLine()) * 1000000));
            if (firstNumber.ToString() == secondNumber.ToString())
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
    }
}
