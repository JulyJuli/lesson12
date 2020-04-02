using System;
using System.Collections.Generic;

namespace Task1
{
    public class IsoscelesTrapezoid
    {
        public IsoscelesTrapezoid(Point a, Point b, Point c, Point d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            HeightTrapezoid = HeightTrapezoid;
            AD = AD;
            AB = AB;
            BC = BC;
            CD = CD;
            Area = Area;
        }

        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }
        public Point D { get; set; }

        private double _area;
        public double Area
        {
            get => _area;
            set
            {
                _area = GetArea();
            }
        }

        private double _ab;
        public double AB
        {
            get => _ab;
            set
            {
                _ab = Math.Round(CutLenghtAB(), 2);
            }
        }

        private double _bc;
        public double BC
        {
            get => _bc;
            set
            {
                _bc = CutLenghtBC();
            }
        }

        private double _cd;
        public double CD
        {
            get => _cd;
            set
            {
                _cd = Math.Round(CutLenghtCD(), 2);
            }
        }

        private double _ad;
        public double AD
        {
            get => _ad;
            set
            {
                _ad = CutLenghtAD();
            }
        }

        private double _height;
        public double HeightTrapezoid
        {
            get => _height;
            set
            {
                _height = Height();
            }
        }

        public double CutLenghtAB()
        {
            return Math.Sqrt(Math.Pow(HeightTrapezoid, 2) + Math.Pow(B.X - A.X, 2));
        }

        public double CutLenghtCD()
        {
            return Math.Sqrt(Math.Pow(HeightTrapezoid, 2) + Math.Pow((D.X - C.X), 2));
        }

        public double CutLenghtBC()
        {
            return C.X - B.X;
        }

        public double CutLenghtAD()
        {
            return D.X - A.X;
        }

        public double Height()
        {
            return B.Y - A.Y;
        }

        public string ChekIsoscelesTrapezoid()
        {
            string checkResult = AB == CD ? $"The trapezoid is isosceles" : $"The trapezoid is not isosceles";

            return checkResult;
        }

        public double GetArea()
        {
            return (BC + AD) * HeightTrapezoid / 2;
        }

        public double GetPerimetr()
        {
            double perimetr = AB + BC + CD + AD;
            return Math.Round(perimetr, 2);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Height: {HeightTrapezoid}\tLenght AB: {AB}\t\tLenght BC: {BC}\tLenght CD: {CD}\t\tLenght AD: {AD}\tPerimetr: {GetPerimetr()}\tArea: {Area}");
        }

        public static double AverageValue(List<IsoscelesTrapezoid> trapezoides)
        {
            double sumArea = 0;

            for (int i = 0; i < trapezoides.Count; i++)
            {
                sumArea += trapezoides[i].Area;
            }
            return sumArea / trapezoides.Count;
        }
    }
}
