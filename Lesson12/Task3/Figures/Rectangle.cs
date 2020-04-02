
namespace Task3.Figures
{
    public class Rectangle : Square
    {
        private double _width = 1;
        private double _height = 1;
        public Rectangle(double height, double width) : base(height) 
        {
            Width = width;
            //Height = height;
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

        public double Height
        {
            get => _height;
            set
            {

                if (value > 0)
                {
                    _height = value;
                }
            }
        }
        protected override string FigureType => "Rectangle";


        public override double GetArea()
        {
            return Height*Width;
        }

        public override double GetPerimetr()
        {
            return (Height+Width)*2;
        }
    }

    }
