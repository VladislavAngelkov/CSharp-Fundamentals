using System;
using System.Linq;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (inputArray.Length == 1)
            {
                Console.WriteLine($"{inputArray[0]}");
                return;
            }
            int sum = 0;
            for (int i = inputArray.Length-1; i >= 1; i--)
            {
                
                int[] currentArray = new int[i];
                for (int j = 0; j < currentArray.Length; j++)
                {
                    currentArray[j] = inputArray[j] + inputArray[j + 1];
                }
                inputArray = currentArray;
                sum = currentArray[0];
            }
            Console.WriteLine(sum);
        }
    }
}
