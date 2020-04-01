using System;

namespace Task2
{
    public class Circles
    {
        public Circles(double x, double y, double radius)
        {
            X = x;
            Y = y;
            Radius = radius;

        }
        private double _radius;

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

        public double X { get; set; }
        public double Y { get; set; }

        public double Area()
        {
            return Math.Round((Math.PI * Math.Pow(Radius, 2)), 2);
        }

        public double Perimetr()
        {
            return 2 * Math.PI * Radius;
        }

        public static string CheckTwoAreas(double area1, double area2)
        {
            if (area1 == area2)
            {
                return $"These areas are equal";
            }
            return $"These areas are not equal";
        }
    }
}
