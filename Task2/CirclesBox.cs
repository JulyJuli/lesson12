using System;
using System.Collections.Generic;
using Task2.Interfaces;

namespace Task2
{
    public class CirclesBox
    {
        public List<IFigureInfo> Circles { get; }
        
        public CirclesBox()
        {
            Circles = new List<IFigureInfo>();
        }

        public void CheckTwoCircles(IFigureInfo circle1, IFigureInfo circle2)
        {
            if (circle1.GetArea() != circle2.GetArea())
            {
                Console.WriteLine($"\nCircle area \"{circle1.Name}\" ({circle1.GetArea()}) is not equal to circle area \"{circle2.Name}\" ({circle2.GetArea()}).\n");
            }
            else
            {
                Console.WriteLine($"\nCircle area \"{circle1.Name}\" ({circle1.GetArea()}) is equal to circle area \"{circle2.Name}\" ({circle2.GetArea()}).\n");
            }
        }
    }
}