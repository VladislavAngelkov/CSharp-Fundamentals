using System;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double[] coordinates = CenterCosest(x1, y1, x2, y2);
            Console.Write("(");
            Console.Write(string.Join(", ", coordinates));
            Console.WriteLine(")");
        }

        static double[] CenterCosest(double x1, double y1, double x2, double y2)
        {
            double[] coordinates = new double[2];
            if ((x1*x1+y1*y1)>(x2*x2+y2*y2))
            {
                coordinates = new double[] { x2, y2};
            }
            else
            {
                coordinates = new double[] { x1, y1 };
            }
            return coordinates;
        }
    }
}
