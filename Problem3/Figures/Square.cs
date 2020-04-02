using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Figures
{
    public class Square : BaseFigure
    {
        private double _sideSize = 1;
        public Square(double sideSize)
        {

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

        protected override string FigureType => "Square";

        public override double GetArea()
        {
            return Math.Pow(SideSize, 2);
        }

        public override double GetPerimeter()
        {
            return SideSize * 4;
        }
    }
}
