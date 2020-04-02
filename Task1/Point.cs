using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public struct Point
    {
        public Point(double axisX, double axisY)
        {
            AxisX = axisX;
            AxisY = axisY;
        }

        public double AxisX { get; }
        public double AxisY { get; }
    }
}
