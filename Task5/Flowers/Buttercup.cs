namespace Task5.Flowers
{
    public class Buttercup : Flower
    {
        public override string FlowerSort => "Buttercup";

        protected override decimal Price { get; set; } = 5;
    }
}
