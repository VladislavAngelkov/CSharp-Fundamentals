using System;

namespace RageExpences
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGameCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int brokeHeadsets = 0;
            int brokeMoses = 0;
            int brokeKeyboards = 0;
            int brokeDisplays = 0;
            for (int i = 1; i <= lostGameCount; i++)
            {
                if (i % 12 == 0)
                {
                    brokeDisplays++;
                    brokeKeyboards++;
                    brokeMoses++;
                    brokeHeadsets++;
                }
                else if (i % 6 == 0)
                {
                    brokeKeyboards++;
                    brokeMoses++;
                    brokeHeadsets++;
                }
                else if (i % 3 == 0)
                {
                    brokeMoses++;
                }
                else if (i % 2 == 0)
                {
                    brokeHeadsets++;
                }
            }
            double rageExpences = brokeHeadsets * headsetPrice + brokeMoses * mousePrice + brokeKeyboards * keyboardPrice + brokeDisplays * displayPrice;
            Console.WriteLine($"Rage expenses: {rageExpences:f2} lv.");
        }
    }
}
