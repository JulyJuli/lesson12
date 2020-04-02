using System;
using Task1;

namespace Task2
{
    public class Circle
    {
        //Окружность
        //Создайте класс окружностей на плоскости, описав в нём все необходимые свойства, подобрав им понятные имена и правильные
        //типы данных.
        //Опишите в классе конструктор, позволяющий при создании нового объекта явно задать все его свойства.Если это необходимо,
        //то проверьте допустимость их значений в конструкторе(например, в классе обыкновенных дробей нельзя создавать дробь с нулевым
        //знаменателем).
        //Создайте в классе метод, проверяющий имеют ли две окружности равную площадь.
        
        private double _radius;
        private double _area;
        private double _cercleLength;
        private double _diametr;
        public Circle(Point center, double radius)
        {
            Center = center;
            Radius = radius;
            Diametr = Diametr;
            Area = Area;
            CircleLength = CircleLength;
        }

        public double Radius
        {
            get => _radius;
            set
            {
                if (value > 0)
                    _radius = value;
                else
                    PrintValidationMessage("Radius");
            }
        }
        public double Diametr
        {
            get => _diametr;
            set
            {
                value = 2 * Radius;
                _diametr = value;
            }
        }
        public Point Center { get; set; }
        public double CircleLength
        {
            get => _cercleLength;
            set
            {
                value = 2 * Math.PI * Radius;
                _cercleLength = value;
            }
        }

        private double Area
        {
            get => _area;
            set
            {
                value = Math.PI * Math.Pow(Radius, 2);
                _area = value;
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Circle with {nameof(Radius)}{Radius,5} has:\n|{nameof(Diametr)}:{Diametr,4}|{nameof(CircleLength)}:{CircleLength,4}" +
                $"|{nameof(Area)}:{Area,4}|");
        }

        protected void PrintValidationMessage(string property)
        {
            Console.WriteLine($"Invalid input in {property}!!! Try again!");
        }

        public static string CompareTwoCircles(Circle circle1, Circle circle2)
        {
            string compareStr =circle1.Area.CompareTo(circle2.Area)==0?"Areas are equal":"Areas aren't equal";
            return compareStr;
        }
    }
    }
