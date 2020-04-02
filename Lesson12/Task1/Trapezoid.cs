using System;

namespace Task1
{
    public class Trapezoid
    {
        //Предусмотреть в классе конструктор и методы:
        //проверка, является ли фигура равнобедренной трапецией;
        //вычисления и вывода сведений о фигуре: длины сторон, периметр, площадь.
        //В функции main продемонстрировать работу с классом:
        //дано N трапеций, найти количество трапеций, у которых площадь больше средней площади.
        //private double _ab =1;
        private double _area;

        public Trapezoid(Point a, Point b, Point c, Point d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            //AB = AB;
            Area = Area;
            
        }

        Point A { get; set; }
        Point B { get; set; }
        Point C { get; set; }
        Point D { get; set; }

        //public double AB
        //{
        //    get => _ab;
        //    set

        //    {
        //        value =  Math.Round(Math.Sqrt(Math.Pow(B.Y - A.Y, 2) + Math.Pow(B.X - A.X, 2)), 2);
        //        if (value > 0)
        //         _ab = value;
        //    }
        //}
        public double Area
        {
            get => _area;
            set
            {
                value = GetArea(C.X - B.X, D.X - A.X);
                _area = value;
            }
        }
        private string GetSideLength(out int da, out double ab, out int bc, out double cd)
        {
            bc =C.X - B.X;
            da = D.X - A.X;
            ab = Math.Round(Math.Sqrt(Math.Pow(B.Y - A.Y, 2) + Math.Pow(B.X - A.X, 2)),2);
            cd = Math.Round(Math.Sqrt(Math.Pow(C.Y - D.Y, 2) + Math.Pow(D.X - C.X, 2)), 2);

           string info= SidesInfo(da, bc, ab, cd);
            return info;
        }     

            private double GetPerimetr(int da, int bc, double ab, double cd)
        {
            return da + bc + ab + cd;
        }

        ////Площадь трапеции равна произведению полусуммы ее оснований (a, b) на высоту (h): 1.
        public double GetArea(int da, int bc)
        {
            return ((double)da + bc) / 2 * (B.Y - A.Y);
        }

        private string SidesInfo(int da, int bc, double ab, double cd)
        {            
            return $"lowerBase {da,4}| upperBase {bc,3}| leftSide {ab,5}| rightSide {cd,5}|";
        }

        private string GetCheck(double ab, double cd)
        {
            string answer = ab==cd?" is isosceles": "isn't isosceles";            
            return answer;
        }

        public void PrintInfo(int number)
        {
            Console.WriteLine($"Trapezoid {number}: {GetSideLength(out int da, out double ab, out int bc, out double cd),40}" +
                $" {GetCheck(ab,cd),15}|Perimetr: {GetPerimetr(da, bc, ab, cd),6}|Area:{GetArea(da, bc),5}");
        }

        //public void PrintInfo1()
        //{
        //    Console.WriteLine($"Trapezoid:{AB}") ;
        //}


    }
}
