

namespace Task4.Items
{
    public class WoodenRaw : RawBase
    {
        public WoodenRaw(double volume, string treeName) : base(volume)
        {
            TreeName = treeName;
        }
        public override string RawType => "Wood";
        public string TreeName { get; }
        public override string ToString()
        {
            return base.ToString() + $"Tree type is {TreeName}";
        }
    }
}
