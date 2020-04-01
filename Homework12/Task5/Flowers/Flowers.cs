using System;
using System.Collections.Generic;

namespace Task5.Flowers
{
    public class Flowers
    {
        private double _price = 1;
        public virtual string FlowersName { get; }
        public virtual double Price
        {
            get => _price;
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }
        public static double FindingPriceOfBouquet(List<Flowers> bouquet)
        {
            double priceOfBouquet = 0;
            for (int i = 0; i < bouquet.Count; i++)
            {

                priceOfBouquet += bouquet[i].Price;

            }
            return priceOfBouquet;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Flowers name: {FlowersName}, price flowers has {Price}");
        }



    }
}