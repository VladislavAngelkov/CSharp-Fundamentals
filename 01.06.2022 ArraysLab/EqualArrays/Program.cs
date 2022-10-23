using System;
using System.Linq;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool areIdentical = true;
            int diffIndex = 0;
            int sum = 0;
            if (firstArray.Length==secondArray.Length)
            {
                
                for (int i = 0; i < firstArray.Length; i++)
                {
                    sum += firstArray[i];
                    if (firstArray[i]!=secondArray[i])
                    {
                        areIdentical = false;
                        diffIndex = i;
                        break;
                    }
                }
            }
            else
            {
                areIdentical = false;
            }
            if (areIdentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {diffIndex} index");
            }
        }
    }
}
