using System;

namespace Task3.Figures
{
    public class Square : BaseFigure
    {
        private double _sideSize = 1;
        protected override string FigureType => "Square";


        public Square(double sideSize)
        {
            SideSize = sideSize;
        }

        public double SideSize
        {
            get => _sideSize;
            set
            {
                if (value > 0)
                {
                    _sideSize = value;
                }
            }
        }


        public override double GetArea()
        {
            return Math.Pow(SideSize, 2);
        }
        public override double GetPerimeter()
        {
            return 4 * SideSize;
        }
    }
}
