using System;

namespace PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            string text = "";
            for (int i = start; i <= end; i++)
            {
                text += (char)i+" ";
            }
            Console.WriteLine(text);
        }
    }
}
