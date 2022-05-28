using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int elevarotCapacity = int.Parse(Console.ReadLine());
            double coursesCount = Math.Ceiling((double)numberOfPeople / (double)elevarotCapacity);
            Console.WriteLine(coursesCount);
        }
    }
}
