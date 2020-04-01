using System;

namespace Task2
{
    public class Circle
    {
        private double _radius;
        public CircleCenter CenterPoint { get; protected set; }
        public double Radius
        {
            get => _radius;
            protected set
            {
                if (value > 0) { _radius = value; }
                else { _radius = 0; }
            }
        }


        public Circle(int circleCenterX, int circleCenterY, double radius)
        {
            CenterPoint = new CircleCenter(circleCenterX, circleCenterY);
            Radius = radius;
        }


        public string GetInfo()
        {
            return $"center point: ({CenterPoint.CoordinateX},{CenterPoint.CoordinateY}); radius: {_radius}.";
        }

        public double GetArea()
        {
            return Math.PI * _radius;
        }
    }
}
