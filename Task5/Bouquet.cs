using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.Flowers;

namespace Task5
{
    public class Bouquet
    {
        public Bouquet()
        {
            Flowers = new List<Flower>();
        }

        public List<Flower> Flowers { get; set; }

        public int GetBouquetPrice()
        {
            int bouquetPrice = 0;

            foreach(Flower flower in Flowers)
            {
                bouquetPrice += flower.Price;
            }

            return bouquetPrice;
        }

        public void PrintInfo()
        {
            foreach (Flower flower in Flowers)
            {
                Console.WriteLine(flower);
            }

            Console.WriteLine();
            Console.WriteLine($"Total bouquet price is {GetBouquetPrice()}");
        }
    }
}
