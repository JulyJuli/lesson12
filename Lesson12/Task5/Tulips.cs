

namespace Task5
{
    public class Tulips : Flower
    {
        private decimal _price;
        public Tulips(decimal price = 25) : base(price)
        {
            FlowerCost = price;
        }
        public override string FlowerName => "Tulip";

        public override decimal FlowerCost
        {
            get
            {
                return _price;
            }
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
