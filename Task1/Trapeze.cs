using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BaseClasses;
using Task1.Points;

namespace Task1
{
    public class Trapeze
    {
        public Point PointA { get; private set; }
        public Point PointB { get; private set; }
        public Point PointC { get; private set; }
        public Point PointD { get; private set; }
        public double ABLength { get => GetLength(PointA, PointB); }
        public double BCLength { get => GetLength(PointB, PointC); }
        public double CDLength { get => GetLength(PointD, PointC); }
        public double ADLength { get => GetLength(PointD, PointA); }


        public Trapeze(Point pointA, Point pointB, Point pointC, Point pointD)
        {
            PointA = pointA;
            PointB = pointB;
            PointC = pointC;
            PointD = pointD;
        }

        public bool IsIsoscelles()
        {
            if (GetLength(PointA, PointB) == GetLength(PointC, PointD)) { return true; }
            return false;
        }
        private double GetLength(Point startPoint, Point finishPoint)
        {
            return (Math.Sqrt(Math.Pow(Math.Abs(startPoint.CoordinteX - finishPoint.CoordinteX), 2) + Math.Pow(Math.Abs(startPoint.CoordinteY - finishPoint.CoordinteY), 2)));
        }

        public double GetPerimeter()
        {
            return ABLength + BCLength + CDLength + ADLength;
        }
        public double GetArea()
        {
            return (BCLength + ADLength) / 2 * (Math.Abs(PointA.CoordinteY - PointB.CoordinteY));
        }



    }
}
