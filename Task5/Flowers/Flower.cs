using Task5.Interfaces;

namespace Task5.Flowers
{
    public abstract class Flower : IFlower
    {
        public abstract string FlowerSort { get; }
        protected abstract decimal Price { get; set; }


        public string GetFlowerInfo()
        {
            return $"Flower sort: {FlowerSort}; price, per: {Price}.";
        }
        public decimal GetPrice()
        {
            return Price;
        }
        public void SetPrice(decimal newPrice)
        {
            if (newPrice > 0) { Price = newPrice; }
        }
        public string GetFlowerSort()
        {
            return FlowerSort;
        }
    }
}
