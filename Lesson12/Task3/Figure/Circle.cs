using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Figure
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

        public override double GetPerimiter()
        {
            return Math.Pow(Radius, 2);
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }



    }
}
