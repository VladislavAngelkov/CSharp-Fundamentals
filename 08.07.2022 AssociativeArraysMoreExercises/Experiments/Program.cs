using System;
using System.Collections.Generic;
using System.Linq;

namespace Experiments
{
    class Dwarf
    {
        public string Name { get; set; }
        public string HatColor { get; set; }

        public override bool Equals(object obj)
        {
            Dwarf other = obj as Dwarf;

            if (other.Name == null || other.HatColor==null)
            {
                return false;
            }
            else if (other.Name!=this.Name || other.HatColor!=this.HatColor)
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

            Dwarf dwarf = new Dwarf();
            dwarf.Name = "Falgin";
            dwarf.HatColor = "red";

            dwarfs.Add(dwarf, 100);

            Dwarf newDwarf = new Dwarf();
            newDwarf.Name = Console.ReadLine();
            newDwarf.HatColor = Console.ReadLine();

            if (dwarfs.ContainsKey(newDwarf))
            {
                Console.WriteLine("wtf");
            }
            else
            {
                Console.WriteLine("offfff");
            }

            //if (dwarf.Equals(newDwarf))
            //{
            //    Console.WriteLine("works");
            //}
            //else
            //{
            //    Console.WriteLine("not");
            //}
        }
    }
}
