using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class PlaneCircle
    {
        private double _radius = 1;

        public PlaneCircle(double centerAxisX, double centerAxisY, double radius)
        {
            CenterAxisX = centerAxisX;
            CenterAxisY = centerAxisY;
            Radius = radius;
            Area = GetArea();
        }

        public double CenterAxisX { get; }
        public double CenterAxisY { get; }
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
        public double Area { get; }

        private double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public static bool CompareArea(PlaneCircle circle1, PlaneCircle circle2)
        {
            if (circle1.Area == circle2.Area)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"Circle with center in ({CenterAxisX},{CenterAxisY}), radius = {Radius}, area = {Area}";
        }
    }
}
