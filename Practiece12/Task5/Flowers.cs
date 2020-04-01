using System.Collections.Generic;

namespace Task5
{
    public class Flowers
    {
        public Flowers(double price)
        {
            Price = price;
        }

        private double _price;
        public double Price
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

        public static double CostOfBouquet(List<Flowers> bouquet)
        {
            double costOfBouquet = 0;
            for (int i = 0; i < bouquet.Count; i++)
            {
                costOfBouquet += bouquet[i].Price;
            }
            return costOfBouquet;
        }
    }
}
