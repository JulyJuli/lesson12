namespace Task_4
{
    public class IronRaw : RawBase
    {

        public IronRaw(double volume):base (volume)
        {
            Volume = volume;   
        }
        public override string RawType => "Iron";

    }
}
