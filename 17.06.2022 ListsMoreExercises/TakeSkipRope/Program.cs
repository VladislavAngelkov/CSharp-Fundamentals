using System;
using System.Collections.Generic;

namespace TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] decriptedMessage = Console.ReadLine().ToCharArray();

            List<int> numbers = new List<int>();
            List<string> letters = new List<string>();

            for (int i = 0; i < decriptedMessage.Length; i++)
            {
                int currNumber;
                if (int.TryParse(decriptedMessage[i].ToString(), out currNumber))
                {
                    numbers.Add(currNumber);
                }
                else
                {
                    letters.Add(decriptedMessage[i].ToString());
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i%2==0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }

            List<string> encriptedMessage = new List<string>();

            
            int takeIndex = 0;
            int skipIndex = 0;
            int takeNumer = takeList[takeIndex];
            int skipNumber = skipList[skipIndex];

            for (int i = 0; i < letters.Count; i++)
            {
                if (takeNumer!=0)
                {
                    encriptedMessage.Add(letters[i].ToString());
                    takeNumer--;
                }
                else if (skipNumber!=0)
                {
                    skipNumber--;
                }
                else
                {
                    int temp = i;

                    takeIndex++;

                    if (takeIndex<takeList.Count)
                    {
                        takeNumer = takeList[takeIndex];
                        temp = i - 1;
                    }

                    skipIndex++;

                    if (skipIndex<skipList.Count)
                    {
                        skipNumber = skipList[skipIndex];
                        temp = i - 1;
                    }

                    i = temp;
                }
            }

            Console.WriteLine(string.Join("", encriptedMessage));
        }
    }
}
