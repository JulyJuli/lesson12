using System;

namespace Task1
{
    public class Trapezoid
    {
        public Trapezoid(int leftDownAPointX, int leftDownAPointY, int leftUpBPointX, int leftUpBPointY, int rightUpCPointX, int rightUpCPointY, int rightDownDPointX, int rightDownDPointY)
        {
            LeftDownAPointX = leftDownAPointX;
            LeftDownAPointY = leftDownAPointY;

            LeftUpBPointX = leftUpBPointX;
            LeftUpBPointY = leftUpBPointY;

            RightUpCPointX = rightUpCPointX;
            RightUpCPointY = rightUpCPointY;

            RightDownDPointX = rightDownDPointX;
            RightDownDPointY = rightDownDPointY;

            Height = Height;

            SideAD = SideAD;
            SideAB = SideAB;
            SideBC = SideBC;
            SideCD = SideCD;

            Area = Area;
            Perimeter = Perimeter;
        }

        public int LeftDownAPointX { get; set; }
        public int LeftDownAPointY { get; set; }

        public int LeftUpBPointX { get; set; }
        public int LeftUpBPointY { get; set; }

        public int RightUpCPointX { get; set; }
        public int RightUpCPointY { get; set; }

        public int RightDownDPointX { get; set; }
        public int RightDownDPointY { get; set; }

        private double _height;

        public double Height
        {
            get => _height;
            set
            {
                _height = MethodsHeight();
            }

        }
        public double _sideAB;
        public double SideAB
        {
            get => _sideAB;
            set
            {
                _sideAB = MethodsAB();
            }
        }

        public double _sideAD;
        public double SideAD
        {
            get => _sideAD;
            set
            {
                _sideAD = MethodsAD();
            }
        }

        public double _sideBC;
        public double SideBC
        {
            get => _sideBC;
            set
            {
                _sideBC = MethodsBC();
            }
        }

        public double _sideCD;
        public double SideCD
        {
            get => _sideCD;
            set
            {
                _sideCD = MethodsCD();
            }

        }

        private double _perimeter;
        public double Perimeter
        {
            get => _perimeter;
            set
            {
                _perimeter = MethodsPerimeter();
            }
        }
        private double _area;
        public double Area
        {
            get => _area;
            set
            {
                _area = MethodsArea();
            }
        }

        public int Cathet { get; set; }

        public string Check()
        {
            if (LeftUpBPointY == RightUpCPointY && LeftDownAPointY == RightDownDPointY)
            {
                return $"Isosceles trapezoid";
            }
            return $"Not isosceles trapezoid";
        }


        public int MethodsHeight()
        {
            return LeftUpBPointY - LeftDownAPointY;
        }

        public double MethodsBC()
        {            
            return RightUpCPointX - LeftUpBPointX;
        }

        public double MethodsAD()
        {            
            return RightDownDPointX - LeftDownAPointX;
        }

        public double MethodsCathet()
        {
            return RightDownDPointX - RightUpCPointX;
        }

        public double MethodsAB()
        {
            return Math.Round(Math.Sqrt(Math.Pow(MethodsHeight(), 2) + Math.Pow(MethodsCathet(), 2)));
        }
        public double MethodsCD()
        {
            return MethodsAB();
        }

        public double MethodsPerimeter()
        {
            return MethodsAB() + MethodsAD() + MethodsBC() + MethodsCD();
        }
        public double MethodsArea()
        {

            return ((MethodsBC() + MethodsAD()) * MethodsHeight() / 2);

        }


        public override string ToString()
        {
            return $"Check: {Check()}\n\nAD(a): {SideAD} mm\nAB(b): {SideAB} mm\nBC(c): {SideBC} mm\nCD(d): {SideCD} mm\nHeight: {Height} mm\nPerimeter: {Perimeter} mm\nArea: {Area} mm^2";
        }
    }
}

