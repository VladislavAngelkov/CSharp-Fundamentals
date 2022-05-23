using System;

namespace EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int lastDigit = number % 10;
            string digitName = "";
            if (lastDigit == 0)
            {
                digitName = "zero";
            }
            else if (lastDigit == 1)
            {
                digitName = "one";
            }
            else if (lastDigit == 2)
            {
                digitName = "two";
            }
            else if (lastDigit == 3)
            {
                digitName = "three";
            }
            else if (lastDigit == 4)
            {
                digitName = "four";
            }
            else if (lastDigit == 5)
            {
                digitName = "five";
            }
            else if (lastDigit == 6)
            {
                digitName = "six";
            }
            else if (lastDigit == 7)
            {
                digitName = "seven";
            }
            else if (lastDigit == 8)
            {
                digitName = "eight";
            }
            else if (lastDigit == 9)
            {
                digitName = "nine";
            }
            Console.WriteLine(digitName);
        }
    }
}
