namespace Task4.Items
{
    public class WoodRaw : RawBase
    {
        public WoodRaw(double volume, string treeName) : base(volume)
        {
            TreeName = treeName;
        }

        public string TreeName { get; }

        public override string RawType => "Wood Raw";

        public override string ToString()
        {
            return base.ToString() + $" and Tree type is {TreeName}";
        }
    }
}