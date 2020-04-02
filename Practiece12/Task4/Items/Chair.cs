
namespace Task4.Items
{
    public class Chair : FurnitureBase
    {
        public Chair(string manufacturer) : base(manufacturer)
        {

        }
        public override string FurnitureType => "Chair";
    }
}
