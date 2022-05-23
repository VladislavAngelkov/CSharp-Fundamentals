using System;
using System.Linq;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join("", Console.ReadLine().Reverse().ToArray()));
        }
    }
}
