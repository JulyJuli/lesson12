using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Trapezoid
    {
        public Trapezoid(Point pointA, Point pointB, Point pointC, Point pointD)
        {
            PointA = pointA;
            PointB = pointB;
            PointC = pointC;
            PointD = pointD;

            SideAB = GetLength(PointA, PointB);
            SideBC = GetLength(PointB, PointC);
            SideCD = GetLength(PointC, PointD);
            SideDA = GetLength(PointD, PointA);

            DiagonalAC = GetLength(PointA, PointC);
            DiagonalBD = GetLength(PointB, PointD);

            Perimeter = GetPerimeter(SideAB, SideBC, SideCD, SideDA);
            Area = GetArea(SideBC, SideDA, SideAB, SideCD);
        }

        public Point PointA { get; }
        public Point PointB { get; }
        public Point PointC { get; }
        public Point PointD { get; }

        public double SideAB { get; }
        public double SideBC { get; }
        public double SideCD { get; }
        public double SideDA { get; }

        public double DiagonalAC { get; }
        public double DiagonalBD { get; }

        public double Perimeter { get; }
        public double Area { get; }

        public double GetLength(Point point1, Point point2)
        {
            double side = Math.Sqrt(Math.Pow((point2.AxisX - point1.AxisX), 2) + Math.Pow((point2.AxisY - point1.AxisY), 2));

            return side;
        }

        public double GetPerimeter(double sideA, double sideB, double sideC, double sideD)
        {
            return sideA + sideB + sideC + sideD;
        }

        public double GetArea(double sideA, double sideB, double sideC, double sideD)
        {
            double area = ((sideA + sideB) / 2) *
                Math.Sqrt(Math.Pow(sideC, 2) - Math.Pow((Math.Pow(sideB - sideA, 2) + Math.Pow(sideC, 2) - Math.Pow(sideD, 2)) /
                (2 * (sideB - sideA)), 2));

            return area;
        }

        public bool CheckIfIsosceles()
        {
            if (DiagonalAC == DiagonalBD)
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
            return $"Trapezoid where AB = {SideAB}, BC = {SideBC}, CD = {SideCD}, DA = {SideDA}\nPerimeter = {Perimeter}, Area = {Area}\nIsosceles: {CheckIfIsosceles()}";
        }
    }
}
