using System;
using System.Linq;

namespace CaminoFactoryThirdTry
{
    class Program
    {
        static void Main(string[] args)
        {
            int DNALength = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] bestDNA = new int[DNALength];
            int bestSequenceLength = 0;
            int bestSequenceStartingIndex = 0;
            int bestDNASum = 0;
            int currentDNANumber = 0;
            int bestDNANumber = 0;
            while (input != "Clone them!")
            {
                int currentSequenceLength = 0;
                int currentSequenceStartingIndex = 0;
                currentDNANumber++;
                int[] currentDNA = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int currentDNASum = currentDNA.Sum();
                for (int i = 0; i < currentDNA.Length; i++)
                {

                    if (currentDNA[i] == 1)
                    {
                        currentSequenceLength++;
                        if (currentSequenceLength > bestSequenceLength)
                        {
                            bestSequenceLength = currentSequenceLength;
                            bestDNANumber = currentDNANumber;
                            bestDNA = currentDNA;
                            bestSequenceStartingIndex = i + 1 - bestSequenceLength;
                            bestDNASum = currentDNASum;
                        }
                        else if (currentSequenceLength == bestSequenceLength)
                        {
                            if (currentSequenceStartingIndex < bestSequenceStartingIndex)
                            {
                                bestDNANumber = currentDNANumber;
                                bestDNA = currentDNA;
                                bestSequenceStartingIndex = i + 1 - bestSequenceLength;
                                bestDNASum = currentDNASum;
                            }
                            else if (currentSequenceStartingIndex == bestSequenceStartingIndex)
                            {
                                if (currentDNASum > bestDNASum)
                                {
                                    bestDNANumber = currentDNANumber;
                                    bestDNA = currentDNA;
                                    bestDNASum = currentDNASum;
                                }

                            }

                        }
                    }
                    else
                    {
                        currentSequenceLength = 0;
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestDNANumber} with sum: {bestDNASum}.");
            Console.WriteLine(string.Join(" ", bestDNA));


        }
    }
}
