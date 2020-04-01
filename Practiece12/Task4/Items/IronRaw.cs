
namespace Task4.Items
{
    public class IronRaw : RawBase
    {
        public IronRaw(double volume, string ironName) : base(volume)
        {
            IronName = ironName;
        }
        public string IronName { get; }

        public override string RawType => "Iron";
    }
}
