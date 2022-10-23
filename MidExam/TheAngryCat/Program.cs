using System;
using System.Linq;

namespace TheAngryCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] householdItems = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int entryPoint = int.Parse(Console.ReadLine());
            string itemType = Console.ReadLine();

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < entryPoint; i++)
            {
                if (itemType == "cheap" && householdItems[i]<householdItems[entryPoint])
                {
                    leftSum += householdItems[i];
                }
                else if (itemType == "expensive" && householdItems[i] >= householdItems[entryPoint])
                {
                    leftSum += householdItems[i];
                }
            }

            for (int i = entryPoint+1; i < householdItems.Length; i++)
            {
                if (itemType == "cheap" && householdItems[i] < householdItems[entryPoint])
                {
                    rightSum += householdItems[i];
                }
                else if (itemType == "expensive" && householdItems[i] >= householdItems[entryPoint])
                {
                    rightSum += householdItems[i];
                }
            }

            if (leftSum>=rightSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }
            else
            {
                Console.WriteLine($"Right - {rightSum}");
            }
        }
    }
}
