using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            for (int i = 0; i < rotations; i++)
            {
                int firstElement = numberArray[0];
                for (int j = 0; j < numberArray.Length-1; j++)
                {
                    numberArray[j] = numberArray[j + 1];
                }
                numberArray[numberArray.Length - 1] = firstElement;
            }
            Console.WriteLine(string.Join(" ", numberArray));
        }
    }
}
