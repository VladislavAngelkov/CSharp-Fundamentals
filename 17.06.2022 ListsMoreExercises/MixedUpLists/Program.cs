using System;
using System.Collections.Generic;
using System.Linq;

namespace MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            List<int> result = new List<int>();

            int firstBoundery;
            int secondBoundery;

            if (firstArray.Length>secondArray.Length)
            {
                firstBoundery = firstArray[firstArray.Length - 2];
                secondBoundery = firstArray[firstArray.Length - 1];
            }
            else
            {
                firstBoundery = secondArray[0];
                secondBoundery = secondArray[1];
            }

            int biggerBoundery;
            int smallerBoundery;

            if (firstBoundery>secondBoundery)
            {
                biggerBoundery = firstBoundery;
                smallerBoundery = secondBoundery;
            }
            else
            {
                biggerBoundery = secondBoundery;
                smallerBoundery = firstBoundery;
            }

            int secondArrIndex = secondArray.Length-1;

            for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
            {
                result.Add(firstArray[i]);
                result.Add(secondArray[secondArrIndex]);
                secondArrIndex--;
            }

            result = result.Where(x => x > smallerBoundery && x < biggerBoundery).OrderBy(x=>x).ToList();

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
