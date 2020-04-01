namespace Task4
{
    public class Wood : RawBase
    {
        private string TreeName { get; set; }
        public override string RawType => "Wooden Raw";


        public Wood(string treeName, double volume) : base(volume)
        {
            TreeName = treeName;
        }


        public override string ToString()
        {
            return base.ToString() + " " + $"Tree type: {TreeName}.";
        }
    }
}
