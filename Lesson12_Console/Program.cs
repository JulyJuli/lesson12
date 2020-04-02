using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;
using Task2;
using Task3.Figures;
using Task4;
using Task4.Interfaces;
using Task4.Items;
using Task5;
using Task5.Flowers;

namespace Lesson12_Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Task 1");

            var trapezoidList = new List<Trapezoid>
            {
                new Trapezoid(new Point(-3, 0), new Point(-2, 2), new Point(2, 2), new Point(3, 0)),
                new Trapezoid(new Point(0, 0), new Point(1, 1), new Point(2, 1), new Point(3, 0)),
                new Trapezoid(new Point(1, 1), new Point(1, 3), new Point(3, 3), new Point(4, 1)),
                new Trapezoid(new Point(-2, -1), new Point(0, 0), new Point(1, 0), new Point(3, -1))
            };

            double areaSum = 0;

            foreach(var trapezoid in trapezoidList)
            {
                Console.WriteLine(trapezoid);
                areaSum += trapezoid.Area;
            }

            double averageArea = areaSum / trapezoidList.Count;

            int aboveAverageCount = 0;

            foreach(var trapezoid in trapezoidList)
            {
                if (trapezoid.Area > averageArea)
                {
                    aboveAverageCount++;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Number of trapezoids with above average areas: {aboveAverageCount}");

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Task 2");

            var circle1 = new PlaneCircle(0, 0, 12);
            var circle2 = new PlaneCircle(3, 5, 11);

            Console.WriteLine(circle1);
            Console.WriteLine(circle2);

            bool areasEquality = PlaneCircle.CompareArea(circle1, circle2);

            if (areasEquality == true)
            {
                Console.WriteLine("Areas are equal");
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Task 3");

            var figures = new List<BaseFigure> { new Circle(15), new Rectangle(10, 80), new Square(10), };

            figures.ForEach(figure => figure.PrintInfo());

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Task 4");

            var storage = new Storage();
            storage.Products.AddRange(new List<IInfo>
            {
                new Chair("Mebli"),
                new IronRaw(100),
                new WoodenRaw(500, "Oak"),
                new Chair("DreamChair")
            });

            storage.Products.ForEach(product => product.PrintInfo());

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Task 5");

            var bouquet = new Bouquet();
            bouquet.Flowers.AddRange(new List<Flower>
            {
                new Rose(),
                new Rose(),
                new Rose(),
                new Clove(),
                new Clove(),
                new Tulip(),
                new Tulip(),
            });

            bouquet.PrintInfo();
        }
    }
}
