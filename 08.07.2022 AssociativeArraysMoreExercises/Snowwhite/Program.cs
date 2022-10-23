using System;
using System.Collections.Generic;
using System.Linq;

namespace Snowwhite
{
    class Dwarf
    {
        public string Name { get; set; }
        public string HatColor { get; set; }
        //public int Physics { get; set; }
        public int HatCount { get; set; }

        public override bool Equals(object obj)
        {
            Dwarf otherDwarf = obj as Dwarf;

            if (otherDwarf.Name==null || otherDwarf.HatColor==null)
            {
                return false;
            }
            else if (otherDwarf.Name!=this.Name || otherDwarf.HatColor!=this.HatColor)
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
            return HashCode.Combine(Name, HatColor);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Dwarf, int> dwarfs = new Dictionary<Dwarf, int>();

            string[] dwarfInfo = Console.ReadLine().Split(" <:> ");

            while (dwarfInfo.Length != 1)
            {
                string name = dwarfInfo[0];
                string hat = dwarfInfo[1];
                int physics = int.Parse(dwarfInfo[2]);

                Dwarf dwarf = new Dwarf();
                dwarf.Name = name;
                dwarf.HatColor = hat;

                if (!dwarfs.ContainsKey(dwarf))
                {
                    dwarfs.Add(dwarf, physics);
                }
                else if (dwarfs[dwarf]<physics)
                {
                    dwarfs[dwarf] = physics;
                }

                dwarfInfo = Console.ReadLine().Split(" <:> ");
            }

            CalculateHatCount(dwarfs);

            dwarfs = dwarfs.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key.HatCount).ToDictionary(x => x.Key, x => x.Value);

            foreach (var dwarf in dwarfs)
            {
                Console.WriteLine($"({dwarf.Key.HatColor}) {dwarf.Key.Name} <-> {dwarf.Value}");
            }
        }

        public static void CalculateHatCount(Dictionary<Dwarf, int> dwarfs)
        {
            foreach (var dwarf in dwarfs)
            {
                int hatCount = 1;
                foreach (var otherDwarf in dwarfs)
                {
                    if (otherDwarf.Key.HatColor == dwarf.Key.HatColor)
                    {
                        hatCount++;
                    }
                }

                dwarf.Key.HatCount = hatCount;
            }
        }
    }
}
