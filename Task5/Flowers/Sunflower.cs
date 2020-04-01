namespace Task5.Flowers
{
    public class Sunflower : Flower
    {
        public override string FlowerSort => "Sunflower";

        protected override decimal Price { get; set; } = 7;
    }
}
