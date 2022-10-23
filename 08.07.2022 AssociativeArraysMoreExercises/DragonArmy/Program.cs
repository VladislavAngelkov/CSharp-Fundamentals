using System;
using System.Collections.Generic;
using System.Linq;

namespace DragonArmy
{
    class Dragon
    {
        //private double _demage = 45.00;
        //private double _health = 250.00;
        //private double _armor = 10.00;
        public string Type { get; set; }
        public string Name { get; set; }
        public double Damage { get; set; } = 45;
        //{
        //    get
        //    {
        //        return _demage;
        //    }
        //    set
        //    {
        //        _demage = value;
        //    }
        //}
        public double Health { get; set; } = 250;
        //{
        //    get
        //    {
        //        return _health;
        //    }
        //    set
        //    {
        //        _health = value;
        //    }
        //}
        public double Armor { get; set; } = 10;
        //{
        //    get
        //    {
        //        return _armor;
        //    }
        //    set
        //    {
        //        _armor = value;
        //    }
        //}

        public override bool Equals(object obj)
        {
            Dragon otherDragon = obj as Dragon;

            if (otherDragon.Name == null || otherDragon.Type == null)
            {
                return false;
            }
            else if (otherDragon.Name != this.Name || otherDragon.Type != this.Type)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Type, Name);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDragons = int.Parse(Console.ReadLine());

            Dictionary<string, List<Dragon>> colors = new Dictionary<string, List<Dragon>>();

            for (int i = 0; i < numberOfDragons; i++)
            {
                string[] dragonInfo = Console.ReadLine().Split(" ");

                Dragon dragon = new Dragon();

                string type = dragonInfo[0];
                dragon.Type = type;

                string name = dragonInfo[1];
                dragon.Name = name;

                double damage = -1;
                double health = -1;
                double armor = -1;

                if (double.TryParse(dragonInfo[2], out damage))
                {
                    dragon.Damage = damage;
                }

                if (double.TryParse(dragonInfo[3], out health))
                {
                    dragon.Health = health;
                }

                if (double.TryParse(dragonInfo[4], out armor))
                {
                    dragon.Armor = armor;
                }

                if (!colors.ContainsKey(type))
                {
                    colors.Add(type, new List<Dragon>());
                    colors[type].Add(dragon);
                }
                else if (!colors[type].Contains(dragon))
                {
                    colors[type].Add(dragon);
                }
                else
                {
                    colors[type][colors[type].IndexOf(dragon)].Damage = dragon.Damage;


                    colors[type][colors[type].IndexOf(dragon)].Health = dragon.Health;


                    colors[type][colors[type].IndexOf(dragon)].Armor = dragon.Armor;
                }
            }

            foreach (var type in colors)
            {
                Console.WriteLine($"{type.Key}::({type.Value.Average(x => x.Damage):f2}/{type.Value.Average(x => x.Health):f2}/{type.Value.Average(x => x.Armor):f2})");

                foreach (var dragon in type.Value.OrderBy(x => x.Name))
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                }
            }
        }
    }
}
