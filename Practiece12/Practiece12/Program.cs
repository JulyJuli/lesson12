using System;
using System.Collections.Generic;
using Task1;
using Task4;
using Task3.Figures;
using Task4.Items;
using Task4.Interfaces;
using Task2;
using Task5;

namespace Practiece12
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Task 3\n");

            var figures = new List<BaseFigure> { new Circle(15), new Rectangle(10, 10), new Square(10) };

            figures.ForEach(figure => figure.PrintInfo());

            Console.WriteLine("===========================================");
            Console.WriteLine("Task 4");
            var storage = new Storage();
            storage.Products.AddRange(new List<IInfo> { new Chair("Mebli"),
                new IronRaw(100,""),
                new WoodRaw(500, "Oak"),
                new Chair("DreamChair") });
            storage.Products.ForEach(product => product.PrintInfo());


            Console.WriteLine("===========================================");
            Console.WriteLine("Task 1");

            int countOfTrapezoides = 6;
            var trapezoid1 = new IsoscelesTrapezoid(new Point(2, 1), new Point(4, 5), new Point(7, 5), new Point(9, 1));
            var trapezoid2 = new IsoscelesTrapezoid(new Point(2, 1), new Point(4, 5), new Point(7, 5), new Point(10, 1));
            var trapezoid3 = new IsoscelesTrapezoid(new Point(2, 1), new Point(4, 6), new Point(7, 6), new Point(9, 1));
            var trapezoid4 = new IsoscelesTrapezoid(new Point(2, 1), new Point(4, 7), new Point(7, 7), new Point(9, 1));
            var trapezoid5 = new IsoscelesTrapezoid(new Point(0, 1), new Point(4, 5), new Point(7, 5), new Point(9, 1));
            var trapezoid6 = new IsoscelesTrapezoid(new Point(1, 5), new Point(4, 8), new Point(7, 8), new Point(10, 5));

            List<IsoscelesTrapezoid> allTrapezoids = new List<IsoscelesTrapezoid>();
            allTrapezoids.Add(trapezoid1);
            allTrapezoids.Add(trapezoid2);
            allTrapezoids.Add(trapezoid3);
            allTrapezoids.Add(trapezoid4);
            allTrapezoids.Add(trapezoid5);
            allTrapezoids.Add(trapezoid6);

            foreach (var item in allTrapezoids)
            {
                item.PrintInfo();
            }

            for (int i = 0; i < countOfTrapezoides; i++)
            {
                Console.WriteLine(allTrapezoids[i].ChekIsoscelesTrapezoid());
            }


            int countTrapezoidArea = 0;
            double averageArea = IsoscelesTrapezoid.AverageValue(allTrapezoids);
            for (int i = 0; i < allTrapezoids.Count; i++)
            {
                if (allTrapezoids[i].Area > averageArea)
                {
                    countTrapezoidArea++;
                }
            }

            Console.WriteLine($"\nNumber of trapezoids whose area is greater than the average area: {countTrapezoidArea}");

            Console.WriteLine("===========================================");
            Console.WriteLine("Task 2");

            var circle1 = new Circles(0, 0, 12);
            var circle2 = new Circles(3, 5, 11);

            double areaCircle1 = circle1.Area();
            double areaCircle2 = circle2.Area();

            Console.WriteLine($"Area of 1 circle: {areaCircle1}\t Area of 2 circle: {areaCircle2}\n{Circles.CheckTwoAreas(areaCircle1, areaCircle2)}");

            Console.WriteLine("===========================================");
            Console.WriteLine("Task 5");

            var buket = new Bouqet();
            buket.AddFlower(new Rose(12.5));
            buket.AddFlower(new Rose(11.10));
            buket.AddFlower(new Tulip(45.90));
            buket.AddFlower(new Carnation(38.30));
            buket.AddFlower(new Rose(54.80));

            Console.WriteLine($"Bouquet price: {buket.CostOfBouquet(buket.NewBouqet)}");

            Console.ReadKey();
        }
    }
}
