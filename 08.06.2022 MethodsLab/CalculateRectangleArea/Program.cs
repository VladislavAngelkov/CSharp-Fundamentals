using System;

namespace CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RectangleArea(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
        }
        public static int RectangleArea(int sideA, int sideB)
        {
            int area = sideA * sideB;
            return area;
        }
    }
}
