using System.Collections.Generic;


namespace Task5
{
    public abstract class Flowers
    {
        private double _price = 1;
        public Flowers(double price)
        {
            Price = price;
        }
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
        public abstract string FlowerType { get; }

        public static double GetPriceOfBouquet(List<Flowers> flowers)
        {
            double priceOfBouq = 0;
            for (int i = 0; i < flowers.Count; i++)
            {
                priceOfBouq += flowers[i].Price;
            }
            return priceOfBouq;
        }
    }
}
     
