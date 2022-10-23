using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePowers { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] vehicleInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            List<Vehicle> vehicles = new List<Vehicle>();

            while (vehicleInfo[0] != "End")
            {
                string type = vehicleInfo[0];
                string model = vehicleInfo[1];
                string color = vehicleInfo[2];
                int horsePowers = int.Parse(vehicleInfo[3]);

                Vehicle vehicle = new Vehicle();
                vehicle.Type = type;
                vehicle.Model = model;
                vehicle.Color = color;
                vehicle.HorsePowers = horsePowers;

                vehicles.Add(vehicle);

                vehicleInfo = Console.ReadLine().Split(" ");
            }

            string command = Console.ReadLine();

            while (command != "Close the Catalogue")
            {

                if (vehicles.Any(x=>x.Model == command))
                {
                    Console.WriteLine(vehicles[vehicles.IndexOf(vehicles.First(x => x.Model == command))].Type == "car" ? "Type: Car" : "Type: Truck");
                    Console.WriteLine($"Model: {vehicles[vehicles.IndexOf(vehicles.First(x => x.Model == command))].Model}");
                    Console.WriteLine($"Color: {vehicles[vehicles.IndexOf(vehicles.First(x => x.Model == command))].Color}");
                    Console.WriteLine($"Horsepower: {vehicles[vehicles.IndexOf(vehicles.First(x => x.Model == command))].HorsePowers}");
                }

                command = Console.ReadLine();
            }


            if (vehicles.Any(x=>x.Type == "car"))
            {
                Console.WriteLine($"Cars have average horsepower of: {vehicles.Where(x => x.Type == "car").Average(x => x.HorsePowers):f2}.");
            }
            else
            {
                Console.WriteLine("Cars have average horsepower of: 0.00.");
            }

            if (vehicles.Any(x=>x.Type == "truck"))
            {
                Console.WriteLine($"Trucks have average horsepower of: {vehicles.Where(x => x.Type == "truck").Average(x => x.HorsePowers):f2}.");
            }
            else
            {
                Console.WriteLine("Trucks have average horsepower of: 0.00.");
            }

        }
    }
}
