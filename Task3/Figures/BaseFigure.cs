using System;

namespace Task3.Figures
{
    public abstract class BaseFigure
    {
        protected abstract string FigureType { get; }
        
        public abstract double GetPerimeter();
        
        public abstract double GetArea();

        public void PrintInfo()
        {
            Console.WriteLine($"{FigureType} has perimeter {GetPerimeter()} and area {GetArea()}");
        }
    }
}