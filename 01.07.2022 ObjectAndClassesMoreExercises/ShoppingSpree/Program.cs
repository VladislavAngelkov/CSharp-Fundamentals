using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] personsInfo = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            string[] productsInfo = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            List<Product> products = new List<Product>();

            List<Person> persons = new List<Person>();

            for (int i = 0; i < productsInfo.Length; i++)
            {
                string[] productInfo = productsInfo[i].Split("=");

                string name = productInfo[0];
                decimal price = decimal.Parse(productInfo[1]);

                Product product = new Product(name, price);

                products.Add(product);
            }

            for (int i = 0; i < personsInfo.Length; i++)
            {
                string[] personInfo = personsInfo[i].Split("=");

                string name = personInfo[0];
                decimal money = decimal.Parse(personInfo[1]);

                Person person = new Person(name, money);

                persons.Add(person);
            }

            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "END")
            {
                string personName = command[0];
                string productName = command[1];

                persons[persons.IndexOf(persons.First(x => x.Name == personName))].Buy(products.First(x => x.Name == productName));

                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }
        }
    }

    class Product
    {
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }

    class Person
    {
        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            Products = new List<Product>();
        }
        public string Name { get; set; }
        public decimal Money { get; set; }
        public List<Product> Products { get; set; }

        public void Buy(Product product)
        {
            if (product.Price > this.Money)
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
            else
            {
                this.Products.Add(product);
                this.Money = this.Money - product.Price;

                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Name} - ");

            if (this.Products.Count == 0)
            {
                sb.Append("Nothing bought");
            }
            else
            {
                sb.Append(string.Join(", ", this.Products));
            }

            return sb.ToString();
        }
    }
}
