using System;
using System.Collections.Generic;
using Task3.Figure;
using Task4;
using Task4.Interdaces;
using Task4.Items;

namespace Lesson12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task 3");
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
        }
    }
}
