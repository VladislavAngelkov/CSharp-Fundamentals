using System;
using System.Linq;

namespace MaxSequenceOfEqualsElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxSequenceCount = 1;
            int maxSequenceElement = 0;
            int currentSequenceCount = 1;
            int currentSequenceElement = 0;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i]==numbers[j])
                    {
                        currentSequenceCount++;
                        currentSequenceElement = numbers[i];
                        if (currentSequenceCount>maxSequenceCount)
                        {
                            maxSequenceCount = currentSequenceCount;
                            maxSequenceElement = currentSequenceElement;
                        }
                    }
                    else
                    {
                        currentSequenceCount = 1;
                        currentSequenceElement = 0;
                        i = j - 1;
                        break;
                    }
                }
                currentSequenceCount = 1;
                currentSequenceElement = 0;
            }
            if (maxSequenceCount!=1)
            {
                int[] sequenceArray = new int[maxSequenceCount];
                for (int i = 0; i < sequenceArray.Length; i++)
                {
                    sequenceArray[i] = maxSequenceElement;
                }
                Console.WriteLine(string.Join(" ", sequenceArray));
            }
            else
            {
                Console.WriteLine(numbers[0]);
            }
        }
    }
}
