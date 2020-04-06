using System;
using System.Collections.Generic;
using Task1;
using Task4;
using Task3.Figures;
using Task4.Items;
using Task4.Interfaces;
using Task5;
using Task3;

namespace Leasson12
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("----------------------------");
            Console.WriteLine("Task 1");

            List<Trapezoid> Trapezoids = new List<Trapezoid>()
            {
                new Trapezoid(5,5, 10,20, 30,20, 35,5),
                new Trapezoid(1,2, 50,100, 100,100, 20,2),
                new Trapezoid(5,10, 10,50, 30,50, 35,10),
                new Trapezoid(1,10, 2,20, 3,20, 4,10),
                new Trapezoid(15,5, 20,16, 25,16, 30,5),
                new Trapezoid(30,20, 35,40, 40,40, 45,20),
            };

            double AverageArea()
            {
                double area = 0;
                for (int i = 0; i < Trapezoids.Count; i++)
                {

                    area += Trapezoids[i].MethodsArea();
                }

                return Math.Round(area / Trapezoids.Count);
            }
            

            double CountAverageArea()
            {
                int count = 0;
                for (int i = 0; i < Trapezoids.Count; i++)
                {
                    if (Trapezoids[i].MethodsArea() > AverageArea())
                    {
                        count++;
                    }
                }
                return count;
            }

            void PrintTrapezoid()
            {
                for (int i = 0; i < Trapezoids.Count; i++)
                {
                    Console.WriteLine($"\n{i + 1}) {Trapezoids[i].ToString()}");

                }
            }

            PrintTrapezoid();

            Console.WriteLine($"\nThe number of trapezoids with an area larger than average: { AverageArea()} = {CountAverageArea()}");




            Console.WriteLine("\n\n----------------------------");
            Console.WriteLine("Task 2\n");

            var circleOne = new Task2.Circle("CircleOne", 11, 3, 4);
            Console.WriteLine(circleOne.ToString());

            var circleTwo = new Task2.Circle("CircleTwo", 11, 5, 7);
            Console.WriteLine(circleTwo.ToString());

            if (circleOne.Area() == circleTwo.Area())
            {
                Console.WriteLine($"Area: {circleOne.Name} equal {circleTwo.Name}");
            }

            Console.WriteLine("\n\n----------------------------");
            Console.WriteLine("Task 3");

            var figures = new List<BaseFigure> { new Task3.Figures.Circle(15), new Rectangle(10, 10), new Square(10) };

            figures.ForEach(figure => figure.PrintInfo());


            Console.WriteLine("\n\n----------------------------");
            Console.WriteLine("Task 4");

            var storage = new Storage();
            storage.Products.AddRange(new List<IInfo> { new Chair("Mebli"),
                new IronRaw(100,""),
                new WoodRaw(500, "Oak"),
                new Chair("DreamChair") });
            storage.Products.ForEach(product => product.PrintInfo());


            Console.WriteLine("\n\n----------------------------");
            Console.WriteLine("Task 5\n");

            List<Flower> flowersBouquet = new List<Flower>()
            {
                new Rose("Rose", 5),
                new Rose("Rose", 8),
                new Rose("Rose", 10),
                new Tulips("Tulips", 7),
                new Tulips("Tulips", 10),
                new Tulips("Tulips", 9),
                new Carnations("Carnations", 13),
                new Carnations("Carnations", 25),
                new Carnations("Carnations", 24)
            };

            int sum = 0;

            for (int i = 0; i < Flower.counter; i++)
            {
                sum += flowersBouquet[i].Price;
                Console.WriteLine(flowersBouquet[i].ToString());
            }
            Console.WriteLine($"\nTotal sum {sum} grn");

            Console.ReadKey();
        }
    }
}
