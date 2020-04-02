using System;


namespace Task5
{
    public class Rose : Flower
    {
        private decimal _price;
        public Rose(decimal price=45):base (price)
        {
            FlowerCost = price;
        }
        public override string FlowerName => "Rose";

        public override decimal FlowerCost
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        public void PrintInfo()
        {
            Console.WriteLine(ToString());
        }
    }
}
