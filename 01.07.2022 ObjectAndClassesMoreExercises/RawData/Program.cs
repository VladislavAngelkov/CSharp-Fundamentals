using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carInfo[0];
                int speed = int.Parse(carInfo[1]);
                int power = int.Parse(carInfo[2]);
                int weight = int.Parse(carInfo[3]);
                string type = carInfo[4];

                Car car = new Car(model, speed, power, weight, type);

                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in cars.Where(x=>x.Cargo.Type == "fragile").Where(x=>x.Cargo.Weight<1000))
                {
                    Console.WriteLine(car);
                }
            }
            else if (command == "flamable")
            {
                foreach (var car in cars.Where(x=>x.Cargo.Type == "flamable").Where(x=>x.Engine.Power>250))
                {
                    Console.WriteLine(car);
                }
            }
        }
    }

    class Engine
    {
        public Engine(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }
        public int Speed { get; set; }
        public int Power { get; set; }
    }

    class Cargo
    {
        public Cargo(int weigth, string type)
        {
            Weight = weigth;
            Type = type;
        }
        public int Weight { get; set; }

        public string Type { get; set; }
    }

    class Car
    {
        public Car(string model, int speed, int power, int weight, string type)
        {
            Model = model;
            Engine = new Engine(speed, power);
            Cargo = new Cargo(weight, type);
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }

        public override string ToString()
        {
            return this.Model;
        }
    }
}
