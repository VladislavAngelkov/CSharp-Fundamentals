using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int[] bottomRow = new int[numbers.Length / 2];
            int[] topRowFirstHalf = new int[numbers.Length / 4];
            int[] topRowSecondHalf = new int[numbers.Length / 4];
            for (int i = 0; i < numbers.Length/4; i++)
            {
                topRowFirstHalf[i] = numbers[i];
            }
            topRowFirstHalf = topRowFirstHalf.Reverse().ToArray();
            int counter = 0;
            for (int i = (numbers.Length/4)*3; i < numbers.Length; i++)
            {
                topRowSecondHalf[counter] = numbers[i];
                counter++;
            }
            topRowSecondHalf = topRowSecondHalf.Reverse().ToArray();
            counter = 0;
            for (int i = numbers.Length/4; i < (numbers.Length / 4) * 3; i++)
            {
                bottomRow[counter] = numbers[i];
                counter++;
            }
            int[] topRow = new int[numbers.Length / 2];
            for (int i = 0; i < topRow.Length; i++)
            {
                if (i<topRow.Length/2)
                {
                    topRow[i] = topRowFirstHalf[i];
                }
                else
                {
                    topRow[i] = topRowSecondHalf[i - (topRow.Length / 2)];
                }
            }
            int[] finalArray = new int[topRow.Length];
            for (int i = 0; i < finalArray.Length; i++)
            {
                finalArray[i] = topRow[i] + bottomRow[i];
            }
            Console.WriteLine(string.Join(" ", finalArray));
        }
    }
}
