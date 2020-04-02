

namespace Task5
{
    public class Carnation : Flower
    {
        private decimal _price;

        public Carnation(decimal price=20):base(price)
        {
            FlowerCost = price;  
        }

        public override string FlowerName => "Carnation";

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
