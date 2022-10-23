using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            List<Person> persons = new List<Person>();

            while (input[0] != "End")
            {
                string name = input[0];
                string id = input[1];
                int age = int.Parse(input[2]);

                if (persons.Any(person=>person.ID == id))
                {
                    persons[persons.IndexOf(persons.First(person => person.ID == id))].Name = name;
                    persons[persons.IndexOf(persons.First(person => person.ID == id))].Age = age;
                }
                else
                {
                    Person person = new Person(name, id, age);
                    persons.Add(person);
                }

                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            persons = persons.OrderBy(person => person.Age).ToList();

            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }
        }
    }

    class Person
    {
        public Person( string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Name} with ID: {this.ID} is {this.Age} years old.");
            return sb.ToString();
        }
    }
}
