namespace Task5.Items
{
    public class Tulip : FlowerBase
    {
        public Tulip(string color, int price) : base(color)
        {
            Price = price;
        }

        public override string FlowerType => "Tulip";
    }
}