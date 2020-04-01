using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Figure
{
    public abstract class BaseFigure
    {
        protected abstract string FigureType { get; }

        public abstract double GetPerimiter();

        public abstract double GetArea();

        public void PrintInfo()
        {
            Console.WriteLine($"{FigureType} has perimeter {GetPerimiter()} and area {GetArea()}");
        }
    }
}
