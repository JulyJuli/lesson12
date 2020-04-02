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
    }
}
