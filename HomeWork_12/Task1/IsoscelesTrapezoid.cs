using System;
using System.Collections.Generic;


namespace Task1
{
    public class IsoscelesTrapezoid
    {
        public IsoscelesTrapezoid(Point b, Point c, Point a, Point d)
        {
            TopLeft = b;
            TopRight = c;
            BottomLeft = a;
            BottomRight = d;            
        }
       
        public Point TopLeft { get; set; }
        public Point TopRight { get; set; }
        public Point BottomLeft { get; set; }
        public Point BottomRight { get; set; }
        public void GetIsoscelesTest()
        {
            var diagonalBD = Math.Sqrt(Math.Pow((BottomRight.X - TopLeft.X), 2) + Math.Pow((BottomRight.Y - TopLeft.Y), 2));
            var diagonalAC = Math.Sqrt(Math.Pow((TopRight.X - BottomLeft.X), 2) + Math.Pow((TopRight.Y - BottomLeft.Y), 2));
            if (diagonalAC == diagonalBD)
            {
                Console.WriteLine("This Trapezoid is isosceles ");
            }
            else
            {
                Console.WriteLine("This Trapezoid is nonisosceles ");
            }
        }

        public double GetSideAD()
        {
            return Math.Sqrt(Math.Pow((BottomLeft.X - BottomRight.X), 2) + Math.Pow((BottomLeft.Y - BottomRight.Y), 2));//a
        }
        public double GetSideBC()
        {
            return Math.Sqrt(Math.Pow((TopRight.X - TopLeft.X), 2) + Math.Pow((TopRight.Y - TopLeft.Y), 2));//b
        }
        public double GetSideCD()
        {
            return Math.Sqrt(Math.Pow((BottomRight.X - TopRight.X), 2) + Math.Pow((BottomRight.Y - TopRight.Y), 2));//d
        }
        public double GetSideAB()
        {
            return Math.Sqrt(Math.Pow((TopLeft.X - BottomLeft.X), 2) + Math.Pow((TopLeft.Y - BottomLeft.Y), 2));//c
        }
        public double GetPerimeter()
        {
            return GetSideAB() + GetSideBC() + GetSideCD() + GetSideAD();
        }
        public double GetArea()
        {
            var halfPer = (GetSideAB() + GetSideBC() + GetSideCD() + GetSideAD()) / 2;//halfPerimeter
            var area = ((GetSideAD() + GetSideBC()) / Math.Abs(GetSideAD() - GetSideBC())) * Math.Sqrt((halfPer - GetSideAD()) * (halfPer - GetSideBC()) * (halfPer - GetSideAD() - GetSideAB()) * (halfPer - GetSideAD() - GetSideCD()));
            return area;
        }
        public void GetInfo()
        {
            Console.WriteLine( $"Trapezoid has parameters:\n" +
                $"Side A: {GetSideAD()}\n" +
                $"Side B: {GetSideBC()}\n" +
                $"Side C: {GetSideAB()}\n" +
                $"Side D: {GetSideCD()}\n" +
                $"Perimeter: {GetPerimeter()}\n" +
                $"Area: {GetArea()}\n");
        }
        public static double Mean(List<IsoscelesTrapezoid> trapezoid)
        {
            double sumArea = 0;
            for (int i=0;i< trapezoid.Count; i++)
            {
                sumArea+=trapezoid[i].GetArea();
            }
            return sumArea / trapezoid.Count;
        }        
    }
}
