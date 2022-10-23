using System;

namespace SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            NumberSign(number);
        }
        public static void NumberSign(int number)
        {
            if (number<0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if (number>0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else
            {
                Console.WriteLine("The number 0 is zero.");
            }
        }
    }
}
