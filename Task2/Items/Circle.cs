using System;
using Task2.Interfaces;

namespace Task2.Items
{
    public class Circle : IFigureInfo
    {
        private int _radius = 1;
        public Circle(string name, int radius, int[] point)
        {
            Radius = radius;
            Point = point;
            Name = name;
        }
        
        public string Name { get; }
        public int[] Point { get; set; }

        public int Radius
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
        
        public double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}