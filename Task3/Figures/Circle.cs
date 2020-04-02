using System;

namespace Task3.Figures
{
    public class Circle : BaseFigure
    {
        private double _radius = 1;
        public Circle(double radius)
        {
            Radius = radius;
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

        protected override string FigureType => "Circle";

        public override double GetPerimeter()
        {
            return Math.Pow(_radius, 2);
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}