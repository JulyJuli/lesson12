using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Task3.Figure;
using Task4;
using Task4.Interfaces;
using Task4.Items;
using Task5;
using Task5.Flowers;
using Task5.Interfaces;

namespace Lesson12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 3");
            var figures = new List<BaseFigure>
            {
                new Circle(15),
                new Rectangle(10, 80),
                new Square(10)

            };

            figures.ForEach(figure => figure.PrintInfo());

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Task 4");

            var storage = new Storage();
            storage.Products.AddRange(new List<IInfo>
            {
                new Chair("Mebli"),
                new IronRaw(100),
                new WoodenRaw(500, "oak"),
                new Chair("DreamChair")
            });

            storage.Products.ForEach(product => product.PrintInfo());

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Task 5");

            decimal _totalPrice = 0;
            
            var bouquet = new Bouquet();
            bouquet.Flowers.AddRange(new List<IFlower>
            {
                new Rose("Red", 5),
                new Rose("Yellow", 7),
                new Tulip("White", 10),
                new Carnations("Green", 1),
                new Tulip("Black", 10)
            });

            
            bouquet.Flowers.ForEach(item => _totalPrice += item.Price);
            Console.WriteLine("Total price for bouquet is {0}", _totalPrice);
        }
    }
}
