namespace Task5.Items
{
    public class Carnation : FlowerBase
    {
        public Carnation(string color, int price) : base(color)
        {
            Price = price;
        }

        public override string FlowerType => "Carnation";
    }
}