using System;
using System.Linq;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split(" ").ToArray();
            string[] reverseArray = inputArray.Reverse().ToArray();
            Console.WriteLine(string.Join(" ", reverseArray));
        }
    }
}
