using System;

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstLineX1 = double.Parse(Console.ReadLine());
            double firstLineY1 = double.Parse(Console.ReadLine());
            double firstLineX2 = double.Parse(Console.ReadLine());
            double firstLineY2 = double.Parse(Console.ReadLine());
            double secondLineX1 = double.Parse(Console.ReadLine());
            double secondLineY1 = double.Parse(Console.ReadLine());
            double secondLineX2 = double.Parse(Console.ReadLine());
            double secondLineY2 = double.Parse(Console.ReadLine());
            double firstLineLength = LineLength(firstLineX1, firstLineY1, firstLineX2, firstLineY2);
            double secondLineLength = LineLength(secondLineX1, secondLineY1, secondLineX2, secondLineY2);
            if (secondLineLength > firstLineLength)
            {
                double[] coordinates = CenterCosest(secondLineX1, secondLineY1, secondLineX2, secondLineY2);
                Console.WriteLine("(" + coordinates[0].ToString() + ", " + coordinates[1].ToString() + ")(" + coordinates[2].ToString() + ", " + coordinates[3].ToString() + ")");
            }
            else
            {
                double[] coordinates = CenterCosest(firstLineX1, firstLineY1, firstLineX2, firstLineY2);
                Console.WriteLine("(" + coordinates[0].ToString() + ", " + coordinates[1].ToString() + ")(" + coordinates[2].ToString() + ", " + coordinates[3].ToString() + ")");
            }
        }

        static double LineLength(double x1, double y1, double x2, double y2)
        {
            double length = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            return length;
        }

        static double[] CenterCosest(double x1, double y1, double x2, double y2)
        {
            double[] coordinates = new double[4];
            if ((x1 * x1 + y1 * y1) > (x2 * x2 + y2 * y2))
            {
                coordinates = new double[] { x2, y2, x1, y1 };
            }
            else
            {
                coordinates = new double[] { x1, y1, x2, y2 };
            }
            return coordinates;
        }
    }
}
