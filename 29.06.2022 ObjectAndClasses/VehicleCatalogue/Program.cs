using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class Catalogue
    {
        public Catalogue()
        {
            this.Truks = new List<Truck>();
            this.Cars = new List<Car>();
        }
        public List<Truck> Truks { get; set; }
        public List<Car> Cars { get; set; }
    }

    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePowers { get; set; }
    }
        class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split("/");

            Catalogue catalogue = new Catalogue();

            while (command[0] != "end")
            {
                if (command[0] == "Car")
                {
                    string brand = command[1];
                    string model = command[2];
                    int horsePowers = int.Parse(command[3]);

                    Car car = new Car();
                    car.Brand = brand;
                    car.Model= model;
                    car.HorsePowers = horsePowers;

                    catalogue.Cars.Add(car);
                }
                else if (command[0] == "Truck")
                {
                    string brand = command[1];
                    string model = command[2];
                    int weight = int.Parse(command[3]);

                    Truck truck = new Truck();
                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = weight;

                    catalogue.Truks.Add(truck);
                }

                command = Console.ReadLine().Split("/");
            }

            Console.WriteLine("Cars:");

            foreach (var car in catalogue.Cars.OrderBy(car => car.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePowers}hp");
            }

            Console.WriteLine("Trucks:");

            foreach (var truck in catalogue.Truks.OrderBy(truck => truck.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
}
