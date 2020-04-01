

namespace Task4.Items
{
    public class Chair : FurnitureBase
    {
        public Chair(string manufacture) : base(manufacture)
        {

        }
        public override string FurnitureType => "Chair";
    }
}
