using System;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            int maxNum = 0;
            int midNum = 0;
            int minNum = 0;
            if (numberOne>numberTwo && numberOne>numberThree)
            {
                maxNum = numberOne;
                if (numberTwo > numberThree)
                {
                    midNum = numberTwo;
                    minNum = numberThree;
                }
                else
                {
                    midNum = numberThree;
                    midNum = numberTwo;
                }
            }
            else if (numberTwo>numberOne && numberTwo>numberThree)
            {
                maxNum = numberTwo;
                if (numberOne > numberThree)
                {
                    midNum = numberOne;
                    minNum = numberThree;
                }
                else
                {
                    midNum = numberThree;
                    midNum = numberOne;
                }
            }
            else if (numberThree>numberOne && numberThree>numberTwo)
            {
                maxNum = numberThree;
                if (numberOne > numberTwo)
                {
                    midNum = numberOne;
                    minNum = numberTwo;
                }
                else
                {
                    midNum = numberTwo;
                    midNum = numberOne;
                }
            }
            Console.WriteLine(maxNum);
            Console.WriteLine(midNum);
            Console.WriteLine(minNum);
            
        }
    }
}
