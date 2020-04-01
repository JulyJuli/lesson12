using System;

namespace Task3.Figures
{
    public class Circle : BaseFigure
    {
        public double _radius = 1;
        protected override string FigureType => "Circle";


        public Circle(double radius)
        {
            _radius = Radius;
        }

        public double Radius
        {
            get => _radius;
            set
            {
                if (value > 0)
                {
                    _radius = value;
                }
            }
        }


        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
