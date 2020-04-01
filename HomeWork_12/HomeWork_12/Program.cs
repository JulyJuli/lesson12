using System;
using System.Collections.Generic;
using Task3.Figures;
using Task4;
using Task4.Interfaces;
using Task4.Items;
using Task1;
using Task2;
using Task5;
using Task5.Items;

namespace HomeWork12
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Task 3");
            var figures = new List<BaseFigure> { new Circle(15), new Rectangle(10, 80), new Square(10) };
            figures.ForEach(figure => figure.PrintInfo());

            Console.WriteLine("_______________________________");
            Console.WriteLine("Task 4");
            Console.ReadKey();
            var storage = new Storage();
            storage.Products.AddRange(new List<IInfo> { new Chair("Mebli"), new IronRaw(100), new WoodenRaw(500, "Oak"), new Chair("Dreamchair") });

            storage.Products.ForEach(product => product.PrintInfo());

            Console.WriteLine("Task 1");

            var trapezoid = new List<IsoscelesTrapezoid>()
            {
                new IsoscelesTrapezoid(new Point(2,3),new Point(3,7),new Point(4,5),new Point(5,4)),
                new IsoscelesTrapezoid(new Point(3,5),new Point(4,8),new Point(5,6),new Point(6,5)),
                new IsoscelesTrapezoid(new Point(4,5),new Point(5,9),new Point(6,7),new Point(7,6)),
                new IsoscelesTrapezoid(new Point(5,6),new Point(6,10),new Point(3,8),new Point(8,7)),
                new IsoscelesTrapezoid(new Point(6,7),new Point(7,11),new Point(10,9),new Point(9,8))
            };
            trapezoid.ForEach(trapez => trapez.GetIsoscelesTest());

            Console.WriteLine("_______________________________");

            trapezoid.ForEach(trapez => trapez.GetInfo());

            int counterArea = 0;
            double mean = IsoscelesTrapezoid.Mean(trapezoid);
            for (int i = 0; i < trapezoid.Count; i++)
            {
                if (trapezoid[i].GetArea() > mean)
                {
                    counterArea++;
                }
            }
            Console.WriteLine($"trapezoid, whose area is larger than average {counterArea}");

            Console.WriteLine("_______________________________");
            Console.WriteLine("Task 2");
            var circles = new List<Circles>()
            {
                new Circles(new Point(0, 0), 12),
                new Circles(new Point(3, 5), 11)
            };
            circles.ForEach(circle => circle.GetInfo());
            Console.WriteLine($"{Circles.EqualityCheckArea(circles[0].GetArea(),circles[1].GetArea())}");

            Console.WriteLine("_______________________________");
            Console.WriteLine("Task 5");

            var bouquet = new List<Flowers>()
            {
                new Rose(10),new Lily(11),new Chrysanthemum(17),new Tulip(15),new Tulip(15),new Tulip(15),new Tulip(15)
            };

            Console.WriteLine($"Your bouquet cost:{Flowers.GetPriceOfBouquet(bouquet)}");
            Console.WriteLine("_______________________________");

            Console.ReadKey();
        }
    }
}
