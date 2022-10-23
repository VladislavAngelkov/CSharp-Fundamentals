using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
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
                double fuel = double.Parse(carInfo[1]);
                double consumption = double.Parse(carInfo[2]);

                Car car = new Car(model, fuel, consumption);

                cars.Add(car);
            }

            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "End")
            {
                string carModel = command[1];
                double kilometers = double.Parse(command[2]);

                cars[cars.IndexOf(cars.First(x => x.Model == carModel))].Move(kilometers);

                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }

    class Car
    {
        public Car(string model, double fuel, double consumption)
        {
            Model = model;
            Fuel = fuel;
            Consumption = consumption;
        }
        public string Model { get; set; }

        public double Fuel { get; set; }

        public double Consumption { get; set; }

        public double TraveledDistance { get; set; } = 0;

        public void Move(double kilometers)
        {
            double neededFuel = kilometers * this.Consumption;

            if (neededFuel>this.Fuel)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.Fuel = this.Fuel - neededFuel;
                this.TraveledDistance = this.TraveledDistance + kilometers;
            }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Model);
        }

        public override bool Equals(object obj)
        {
            Car otherCar = obj as Car;
            bool isEqual = false;

            if (otherCar.Model == "")
            {
                isEqual = false;
            }
            else if (otherCar.Model == this.Model)
            {
                isEqual = true;
            }

            return isEqual;
        }

        public override string ToString()
        {
            string text = $"{this.Model} {this.Fuel:f2} {this.TraveledDistance}";

            return text;
        }
    }
}
