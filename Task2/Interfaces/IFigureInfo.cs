namespace Task2.Interfaces
{
    public interface IFigureInfo
    {
        public int Radius { get; set; }
        
        public string Name { get; }
        
        public int[] Point { get; set; }

        public double GetArea();
    }
}