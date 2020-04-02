using System;
namespace Task3.Figures
{
    public abstract class BaseFigure
    {
        protected abstract string FigureType { get; }
        public abstract double GetPerimetr();

        public abstract double GetArea();

        public void PrintInfo()
        {
            Console.WriteLine($"{FigureType} has perimetr {GetPerimetr()} and area {GetArea()}");
        }
    }
}
