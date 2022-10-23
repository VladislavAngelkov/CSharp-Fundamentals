using System;
using System.Linq;

namespace LongetIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] lengths = new int[numbers.Length];
            int[] previous = new int[numbers.Length];
            int bestLength = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                lengths[i] = 1;
                previous[i] = -1;
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j]<numbers[i] && lengths[j]>=lengths[i])
                    {
                        lengths[i] = lengths[j]+1;
                        previous[i] = j;
                    }
                }
                if (lengths[i]>bestLength)
                {
                    bestLength = lengths[i];
                }
            }
            int[] bestSubsequence = new int[bestLength];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (lengths[i] == bestLength)
                {
                    bestSubsequence[bestSubsequence.Length - 1] = numbers[i];
                    int lastIndex = previous[i];
                    for (int j = bestSubsequence.Length-2; j >= 0; j--)
                    {
                        bestSubsequence[j] = numbers[lastIndex];
                        lastIndex = previous[lastIndex];
                    }
                    break;
                }
            }
            Console.WriteLine(string.Join(" ", bestSubsequence));
            
        }
    }
}
