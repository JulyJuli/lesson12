using System;
namespace Task2
{
    public class Circle
    {
        public Circle()
        {
        }

        public Circle(string name, double radius, int coordinateX, int coordinateY)
        {
            Name = name;
            Radius = radius;
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
        }
        public string Name { get; set; }
        public double Radius { get; set; }
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }

        public double Area()
        {           
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Radius: {Radius}, X: {CoordinateX}, Y: {CoordinateY}\n";
        }
    }   
}
