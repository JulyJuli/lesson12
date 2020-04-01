using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BaseClasses
{
    public class Point
    {
        public double CoordinteX { get; set; }
        public double CoordinteY { get; set; }


        public Point(double coordinteX, double coordinteY)
        {
            CoordinteX = coordinteX;
            CoordinteY = coordinteY;
        }
    }
}
