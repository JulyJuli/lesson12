using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Figure
{
    public class Square : BaseFigure
    {
        private double _sideSize = 1;

        public Square(double sideSize)
        {
            SideSize = sideSize;
        }


        public double SideSize
        {
            get => _sideSize;
            set
            {
                if ( value > 0)
                {
                    _sideSize = value;
                }
            }
        }

        protected override string FigureType => "Square";

        public override double GetPerimiter()
        {
            return SideSize * 4;
        }

        public override double GetArea()
        {
            return Math.Pow(SideSize, 2);
        }
    }
}
