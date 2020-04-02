
namespace Task_4
{
    public class Chair : FurnitureBase
    {
        public Chair( string manufacturer): base(manufacturer)
        {

        }
        public override string FurnitureType => "Chair";
    }
}
