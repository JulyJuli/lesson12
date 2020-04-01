using System;

namespace Task2
{
    public class Circle
    {
        private double _radius = 1;

        public Circle(double radius, int x, int y)
        {
            GetRadius = radius;
            GetX = x;
            GetY = y;
        }
        public double GetRadius
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
        public int GetX { get; set; }
        public int GetY { get; set; }

        protected string FigureType => "Circle";
        public double GetArea()
        {
            return Math.PI* Math.Pow(GetRadius, 2);
           
        }
        public double GetPerimeter()
        {
            return Math.PI *2* GetRadius;
        }

        public static string EqualAreasCheck(double areaCircleFirst, double areaCircleSecond)
        {
            if (areaCircleFirst == areaCircleSecond)
            {
                return "Areas this circle is equals";
            }
            else
            {
                return "Areas this circle is not equals";
            }

        }

        public string PrintInfo()
        {
            return $"FigureType: {FigureType}, has perimeter {GetPerimeter():F3}," +
                $" and area {GetArea():F3}";



        }
        public override string ToString()
        {
            return base.ToString();
        }


    }
}
