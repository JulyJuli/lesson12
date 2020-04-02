using System;
using System.Collections.Generic;
using Task5.Interfaces;

namespace Task5
{
    public class Bouquet
    {
        public Bouquet()
        {
            Flowers = new List<IFlowerInfo>();
        }

        public List<IFlowerInfo> Flowers { get; set; }

        public void PrintPrice()
        {
            var total = 0;
            foreach (var flower in Flowers)
            {
                total += flower.Price;
            }
            
            Console.WriteLine($"Bouquet price is {total}!");
        }
    }
}