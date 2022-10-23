using System;
using System.Linq;

namespace EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStrings = int.Parse(Console.ReadLine());
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int[] numbers = new int[numberOfStrings];
            for (int i = 0; i < numberOfStrings; i++)
            {
                string text = Console.ReadLine();
                int sum = 0;
                for (int j = 0; j < text.Length; j++)
                {
                    if (vowels.Contains(text[j]))
                    {
                        sum += text[j] * text.Length;
                    }
                    else
                    {
                        sum += text[j] / text.Length;
                    }
                }
                numbers[i] = sum;
            }
            numbers = numbers.OrderBy(x=>x).ToArray();
            //Console.WriteLine(string.Join("\n", numbers));
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
