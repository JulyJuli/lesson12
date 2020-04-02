using System;
using System.Collections.Generic;
using Task1;
using Task2;
using Task2.Interfaces;
using Task3.Figures;
using Task4;
using Task4.Interfaces;
using Task4.Items;
using Task5;
using Task5.Interfaces;
using Task5.Items;

namespace lesson12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");

            var averageArea = 0.0;
            var trapeziumsBigArea = 0;
            
            var trapeziums = new List<IsoscelesTrapezoid>()
            {
                new IsoscelesTrapezoid(
                    new int[2]{3,1},
                    new int[2]{5,1},
                    new int[2]{8,4},
                    new int[2]{0,4}
                ),
                new IsoscelesTrapezoid(
                    new int[2]{2,1},
                    new int[2]{6,1},
                    new int[2]{7,4},
                    new int[2]{1,4}
                ),
                new IsoscelesTrapezoid(
                    new int[2]{2,1},
                    new int[2]{6,1},
                    new int[2]{7,5},
                    new int[2]{1,5}
                ),
                new IsoscelesTrapezoid(
                    new int[2]{3,1},
                    new int[2]{5,1},
                    new int[2]{8,5},
                    new int[2]{0,5}
                ),
            };
            
            foreach (var trapezoid in trapeziums)
            {
                Console.WriteLine($"\nTrapezoid #{trapeziums.IndexOf(trapezoid) + 1}");
                trapezoid.PrintInfo();
                averageArea += trapezoid.GetArea();
            }
            
            foreach (var trapezoid in trapeziums)
            {
                if (averageArea / trapeziums.Count < trapezoid.GetArea())
                {
                    trapeziumsBigArea++;
                }
            }
            
            Console.WriteLine($"\n{trapeziumsBigArea} trapeziums with an area larger than the average area.");
            
            Console.WriteLine(new String('-', 60));
            Console.WriteLine("Task 2");
            
            var box = new CirclesBox();
            box.Circles.AddRange(new List<IFigureInfo>()
            {
                new Task2.Items.Circle("My Best Circle", 12, new int[]{0,0}),
                new Task2.Items.Circle("Bigest Circle", 11, new int[]{3,5})
            });
            
            box.CheckTwoCircles(box.Circles[0], box.Circles[1]);
            
            Console.WriteLine(new String('-', 60));
            Console.WriteLine("Task 3");
            var figures = new List<BaseFigure>()
            {
                new Square(10),
                new Circle(20),
                new Rectangle(5,7)
            };

            foreach (var figure in figures)
            {
                figure.PrintInfo();
            }
            Console.WriteLine(new String('-', 60));
            Console.WriteLine("Task 4");
            
            var storage = new Storage();
            storage.Products.AddRange(new List<IInfo>()
            {
                new Chair("Meblya"),
                new IronRaw(25),
                new WoodRaw(104, "Sosna"),
                new Chair("Roga i Kopyta")
            });

            foreach (var product in storage.Products)
            {
                product.PrintInfo();
            }
            
            Console.WriteLine(new String('-', 60));
            Console.WriteLine("Task 5");

            var bouquet = new Bouquet();
            bouquet.Flowers.AddRange(new List<IFlowerInfo>()
            {
                new Rose("Red", 150),
                new Rose("White", 170),
                new Tulip("Green", 100),
                new Carnation("Blue", 70),
                new Tulip("Black", 90),
            });
            foreach (var flower in bouquet.Flowers)
            {
                flower.PrintInfo();
            }
            Console.Write("\n");
            
            bouquet.PrintPrice();
        }
    }
}