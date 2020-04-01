using System;
using System.Collections.Generic;

namespace Homework12
{
    public class Trapeze
    {
        public int i = 2;
        public Trapeze(
                int firstX, int firstY,
                int secondX, int secondY,
                int thirdX, int thirdY,
                int fourthX, int fourthY)
        {
            FirstX = firstX;
            FirstY = firstY;
            SecondX = secondX;
            SecondY = secondY;
            ThirdX = thirdX;
            ThirdY = thirdY;
            FourthX = fourthX;
            FourthY = fourthY;

        }

        public int FirstX { get; set; }
        public int FirstY { get; set; }
        public int SecondX { get; set; }
        public int SecondY { get; set; }
        public int ThirdX { get; set; }
        public int ThirdY { get; set; }
        public int FourthX { get; set; }
        public int FourthY { get; set; }

        public double FindingSideA()
        {
            var sideA = Math.Sqrt((Math.Pow(FirstX - FourthX, i)) + (Math.Pow(FirstY - FourthY, i)));
            return sideA;
        }
        public double FindingSideB()
        {
            var sideB = Math.Sqrt((Math.Pow(SecondX - ThirdX, i)) + (Math.Pow(SecondY - ThirdY, i)));
            return sideB;
        }
        public double FindingSideC()
        {
            double sideC = Math.Sqrt((Math.Pow(FirstX - SecondX, i)) + (Math.Pow(FirstY - SecondY, i)));
            return sideC;
        }
        public double FindingSideD()
        {
            double sideD = Math.Sqrt((Math.Pow(ThirdX - FourthX, i)) + (Math.Pow(ThirdY - FourthY, i)));
            return sideD;
        }
        public bool Validation()
        {
            return FindingSideC() == FindingSideD();
        }


        public double GetPerimeter()
        {
            return FindingSideA() + FindingSideB() + FindingSideC() + FindingSideD();
        }

        public double GetArea()
        {
            int k = 4;
            var area = ((FindingSideA() + FindingSideB()) / i) * Math.Sqrt((Math.Pow(FindingSideC(), i) - ((Math.Pow(FindingSideA() - FindingSideB(), i) / k))));
            return area;
        }

        public static double SumArea(List<Trapeze> trapeze)
        {
            double sum = 0;
            for (int i = 0; i < trapeze.Count; i++)
            {

                sum += trapeze[i].GetArea();

            }
            return sum;
        }


        public void PrintInfo()
        {
            Console.WriteLine($"\nFirst Point:{FirstX}, {FirstY};\nSecond Point:{SecondX}, {SecondY}; " +
                $"\nThird Point:{ThirdX}, {ThirdY}; \nFourth Point:{FourthX}, {FourthY}; ");

            Console.WriteLine($"\nSideA: {FindingSideA():F2}; \nSideB: {FindingSideB():F2};" +
                $" \nSideC: {FindingSideC():F2}; \nSideD: {FindingSideD():F2}" +
                $"\nIsosceles trapezoid: {Validation()}");
            if (Validation() == true)
            {
                Console.WriteLine($"\nTrapeze has perimeter: {GetPerimeter():F3} and area: {GetArea():F3}");
            }
            else
            {
                Console.WriteLine("Not isosceles trapezoid");
            }

        }
    }
}