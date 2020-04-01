using System;

namespace Task3.Figures
{
    public class Circle : BaseFigure
    {
        protected override string FigureType => "Ciкcle";

        private double _radius;
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

        public override double GetPerimetr()
        {
            return 2 * Math.PI * Radius;
        }
        public override double GetArea()
        {
            return Math.Pow(Radius, 2);
        }
    }
}
