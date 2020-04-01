using System;
using Task1;

namespace Task2
{
    public class Circles
    {
        private double _radius = 1;
        public Circles(Point center,double radius)
        {
            Cetner = center;
            Radius = radius;
        }
        public Point Cetner { get; set; }
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
        public double GetPerimeter()
        {
            return Math.Pow(Radius, 2);
        }
        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public static string EqualityCheckArea(double areaOne, double areaTwo)
        {
            if (areaOne == areaTwo)
            {
                return $"This areas are aqual ";
            }
            return $"This areas are not aqual ";
        }
        public void GetInfo()
        {
            Console.WriteLine($"Circle has parameters:\n" +
                $"Perimeter: {GetPerimeter()}\n" +
                $"Area: {GetArea()}\n");
        }
    }
}
