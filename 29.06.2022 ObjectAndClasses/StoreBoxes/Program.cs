using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBoxes
{
    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int  Quantity { get; set; }
        public decimal Price
        {
            get
            {
                return this.Quantity * this.Item.Price;
            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            string[] boxInfo = Console.ReadLine().Split();

            List <Box> boxes = new List<Box>();
            
            while (boxInfo[0] != "end")
            {
                Item item = new Item();
                item.Name = boxInfo[1];
                item.Price = decimal.Parse(boxInfo[3]);

                Box box = new Box();
                box.SerialNumber = boxInfo[0];
                box.Quantity = int.Parse(boxInfo[2]);
                box.Item = item;

                boxes.Add(box);

                boxInfo = Console.ReadLine().Split();
            }

            foreach (var box in boxes.OrderByDescending(x=>x.Price))
            {
                Console.WriteLine($"{box.SerialNumber} \n-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity} \n-- ${box.Price:f2}");
            }
        }
    }
}
