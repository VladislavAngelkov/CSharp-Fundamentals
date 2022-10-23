using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            int[] topRow = new int[] { 1 };
            Console.WriteLine(string.Join(" ", topRow));
            int[] bottomRow = new int[2]; 
            for (int i = 0; i < numberOfRows-1; i++)
            {
                bottomRow = new int[i + 2];
                bottomRow[0] = 1;
                bottomRow[bottomRow.Length - 1] = 1;
                for (int j = 1; j < bottomRow.Length-1; j++)
                {
                    bottomRow[j] = topRow[j - 1] + topRow[j];
                }
                Console.WriteLine(string.Join(" ", bottomRow));
                topRow = bottomRow;
            }
        }
    }
}
