using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Figure
{
    public class Rectangle : Square
    {
        private double _width = 1;

        public Rectangle(double height, double widtth) : base(height)
        {

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
            return SideSize * Width;
        }

        public override double GetPerimiter()
        {
            return (SideSize + Width) * 2;
        }
    }
}
