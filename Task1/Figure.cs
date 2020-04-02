using System;

namespace Task1
{
    public class IsoscelesTrapezoid
    {
        private readonly double bottomBaseLength;
        private readonly double topBaseLength;
        private double equalSidesLength = 0;
        private readonly int[] pointA;
        private readonly int[] pointB;
        private readonly int[] pointC;
        private readonly int[] pointD;

        public IsoscelesTrapezoid(int[] a, int[] b, int[] c, int[] d)
        {
            pointA = a;
            pointB = b;
            pointC = c;
            pointD = d;
            topBaseLength = CalculateSide(pointA[0], pointA[1], pointB[0], pointB[1]);
            bottomBaseLength = CalculateSide(pointC[0], pointC[1], pointD[0], pointD[1]);
            CheckEqualSides();
        }

        private void CheckEqualSides()
        {
            var sideBC = CalculateSide(pointB[0], pointB[1], pointC[0], pointC[1]);
            var sideAD = CalculateSide(pointA[0], pointA[1], pointD[0], pointD[1]);
            
            
            if (sideBC != sideAD)
            {
                Console.WriteLine($"Side BC != AD. This trapezoid is not isosceles!");
            }
            else
            {
                equalSidesLength = sideBC;
            }
        }

        private double CalculateSide(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        
        private double GetPerimeter()
        {
            return topBaseLength + equalSidesLength * 2 + bottomBaseLength;
        }

        public double GetArea()
        {
            return (topBaseLength + bottomBaseLength) / 2 *
                   Math.Sqrt(Math.Pow(equalSidesLength, 2) - Math.Pow(topBaseLength - bottomBaseLength, 2) / 4);
        }

        public void PrintInfo()
        {
            if (equalSidesLength != 0)
            {
                Console.WriteLine($"AB = {topBaseLength}");
                Console.WriteLine($"BC = AD = {equalSidesLength}");
                Console.WriteLine($"CD = {bottomBaseLength}");
                Console.WriteLine($"Perimeter = {GetPerimeter()}");
                Console.WriteLine($"Area = {GetArea()}");
            }
        }
    }
}