using System;
using System.Linq;

namespace KaminoFactorySecondTry
{
    class Program
    {
        static void Main(string[] args)
        {
            int DNALength = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] bestDNA = new int[DNALength];
            int bestSequenceLength = -1;
            int bestStartingIndex = -1;
            int bestSum = 0;
            int currentSample = 0;
            int bestSample = 1;
            while (input != "Clone them!")
            {
                currentSample++;

                int[] currentDNA = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int currentSequenceLength = 0;
                int currentSum = currentDNA.Sum();
                for (int i = 0; i < currentDNA.Length; i++)
                {
                    if (currentDNA[i] == 1)
                    {
                        currentSequenceLength++;
                        
                    }
                    else if (currentSequenceLength > bestSequenceLength)
                    {
                        bestSequenceLength = currentSequenceLength;
                        bestStartingIndex = i - currentSequenceLength;
                        bestSum = currentSum;
                        bestDNA = currentDNA;
                        bestSample = currentSample;
                        currentSequenceLength = 0;
                    }
                    else if (currentSequenceLength == bestSequenceLength && i - currentSequenceLength < bestStartingIndex)
                    {
                        bestStartingIndex = i - currentSequenceLength;
                        bestSum = currentSum;
                        bestDNA = currentDNA;
                        bestSample = currentSample;
                        currentSequenceLength = 0;
                    }
                    else if (currentSequenceLength == bestSequenceLength && i - currentSequenceLength == bestStartingIndex && currentSum > bestSum)
                    {
                        bestSum = currentSum;
                        bestDNA = currentDNA;
                        bestSample = currentSample;
                        currentSequenceLength = 0;
                    }
                    else
                    {
                        currentSequenceLength = 0;
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestDNA));
        }
    }
}
