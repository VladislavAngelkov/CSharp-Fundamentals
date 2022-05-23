using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double availableMoney = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightSaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            int lightSabersCount = (int)Math.Ceiling(studentsCount * 1.1);
            int beltCount = studentsCount - (studentsCount / 6);
            double totalPrice = (lightSabersCount * lightSaberPrice) + (studentsCount * robePrice) + (beltCount * beltPrice);
            if (availableMoney>=totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalPrice-availableMoney:f2}lv more.");
            }
        }
    }
}
