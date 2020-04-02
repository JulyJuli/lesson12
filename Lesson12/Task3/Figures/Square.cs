using System;

namespace Task3.Figures
{
    //Есть фигуры (круг, треугольник, прямоугольник), с различными свойствами, но над каждой фигурой можно производить одинаковые действия.
    //Фигуры должны уметь отдавать информацию о себе в определенном формате, которую некая функция будет выводить в какой-нибудь вывод
    //(консоль, текстовый файл). При этом некоторые фигуры могут быть вариациями других (эллипс, квадрат).
    public class Square:BaseFigure
    {
        private double _sideSize = 1;
        public Square(double sideSize)
        {
            SideSize = sideSize;
        }
         public double SideSize
        {
            get => _sideSize;
            set
            {
                if(value>0)
                {
                    _sideSize = value;
                }
            }
        }

        protected override string FigureType => "Square";

        public override double GetPerimetr()
        {
            return SideSize * 4;
        }

        public override double GetArea()
        {
            return Math.Pow(SideSize, 2);
        }
    }
}
