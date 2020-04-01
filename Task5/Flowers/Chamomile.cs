namespace Task5.Flowers
{
    public class Chamomile : Flower
    {
        public override string FlowerSort => "Chamomile";

        protected override decimal Price { get; set; } = 3;
    }
}
