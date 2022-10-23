using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (numberArray.Length == 1)
            {
                Console.WriteLine(numberArray[0]);
                return;
            }
            string greaterIntegers = "";
            for (int i = 0; i < numberArray.Length-1; i++)
            {
                bool isGreater = true;
                for (int j = i+1; j < numberArray.Length; j++)
                {
                    if (numberArray[i]<=numberArray[j])
                    {
                        isGreater = false;
                    }
                }
                if (isGreater)
                {
                    greaterIntegers += numberArray[i].ToString() + " ";
                }
            }
            greaterIntegers += numberArray[numberArray.Length - 1];
            Console.WriteLine(greaterIntegers);
        }
    }
}
