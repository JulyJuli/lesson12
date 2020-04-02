namespace Task5.Items
{
    public class Rose : FlowerBase
    {
        public Rose(string color, int price) : base(color)
        {
            Price = price;
        }

        public override string FlowerType => "Rose";
    }
}