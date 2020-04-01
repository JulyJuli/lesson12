using System;

namespace Task3.Figures
{
    public abstract class BaseFigure
    {
        protected abstract string FigureType { get; }


        public void PrintInfo()
        {
            Console.WriteLine($"{GetType().Name} has perimeter {GetPerimeter():F2} and area {GetArea():F2}.");
        }
        public abstract double GetPerimeter();
        public abstract double GetArea();
    }
}
