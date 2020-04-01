namespace Task3.Figures
{
    public class Rectangle : Square
    {
        private double _width = 1;
        protected override string FigureType => "Rectangle";


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


        public override double GetArea()
        {
            return Width * SideSize;
        }
        public override double GetPerimeter()
        {
            return (Width + SideSize) * 2;
        }
    }
}
