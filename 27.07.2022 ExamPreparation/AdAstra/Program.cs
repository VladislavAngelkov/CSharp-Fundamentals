using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

namespace AdAstra
{
    class Food
    {
        public Food(string name, string expDate, int calories)
        {
            Name = name;
            ExpireDate = expDate;
            Calories = calories;
        }
        public string Name { get; set; }
        public string ExpireDate { get; set; }
        public int Calories { get; set; }

        public override string ToString()
        {
            string text = $"Item: {this.Name}, Best before: {this.ExpireDate}, Nutrition: {this.Calories}";
            return text;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<sign>[#\|])(?<food>[A-Za-z ]+)\k<sign>(?<date>[0-3]\d\/[0-1]\d\/\d{2})\k<sign>(?<calories>\d{1,5})\k<sign>";

            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();

            MatchCollection foodItems = regex.Matches(input);

            if (foodItems.Count == 0)
            {
                Console.WriteLine($"You have food to last you for: 0 days!");
                return;
            }

            BigInteger totalCalories = 0;

            List<Food> foods = new List<Food>();

            foreach (Match item in foodItems)
            {
                string name = item.Groups["food"].Value;
                string expDate = item.Groups["date"].Value;
                int calories = int.Parse(item.Groups["calories"].Value);

                totalCalories += calories;

                Food food = new Food(name, expDate, calories);

                foods.Add(food);
            }

            BigInteger daysToLast = totalCalories / 2000;

            Console.WriteLine($"You have food to last you for: {daysToLast} days!");

            foreach (var food in foods)
            {
                Console.WriteLine(food);
            }
        }
    }
}
