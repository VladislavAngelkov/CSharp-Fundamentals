using System;
using System.Collections.Generic;
using System.Linq;

namespace Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            char[] text = Console.ReadLine().ToCharArray();

            List<char> charList = text.ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                int number = numbers[i];

                int newNumber = 0;

                while (number!=0)
                {
                    newNumber += number % 10;
                    number /= 10;
                }

                numbers[i] = newNumber;
            }

            List<string> result = new List<string>();

            foreach (var num in numbers)
            {
                int index = num;

                if (index>=charList.Count)
                {
                    index /= charList.Count;
                }

                result.Add(charList[index].ToString());
                charList.RemoveAt(index);
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
