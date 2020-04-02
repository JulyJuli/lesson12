namespace Task_4
{
    public class WoodenRaw : RawBase
    {
        //private string _treeName;
        public WoodenRaw(double volume, string treeName) : base(volume)
        {
            TreeName = treeName;
        }

        public override string RawType => "Wood";

        public string TreeName { get; }

        public override string ToString()
        {
            return base.ToString() + $" and Tree type is {TreeName}";
        }
    }
}
