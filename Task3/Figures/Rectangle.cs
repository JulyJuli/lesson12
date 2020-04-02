namespace Task3.Figures
{
    public class Rectangle : Square
    {
        private double _width = 1;
        public Rectangle(double height, double width) : base(height)
        {
            Width = width;
        }
        
        public double Width
        {
            get => _width;
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
            }
        }
        
        protected override string FigureType => "Rectangle";

        public override double GetPerimeter()
        {
            return (SideSize + Width) * 2;
        }

        public override double GetArea()
        {
            return SideSize * Width;
        }
    }
}