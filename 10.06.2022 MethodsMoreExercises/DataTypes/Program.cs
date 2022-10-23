using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            string value = Console.ReadLine();
            switch (dataType)
            {
                case "int":
                    Console.WriteLine(DataOperation(int.Parse(value)));
                    return;
                case "real":
                    Console.WriteLine($"{DataOperation(double.Parse(value)):f2}");
                    return;
                case "string":
                    Console.WriteLine(DataOperation(value));
                    return;
            }

            
        }

        static int DataOperation(int number)
        {
            number *= 2;
            return number;
        }
        
        static double DataOperation(double number)
        {
            number *= 1.5;
            number = Math.Round(number, 2);
            return number;
        }

        static string DataOperation (string text)
        {
            text = "$" + text + "$";
            return text;
        }
    }
}
