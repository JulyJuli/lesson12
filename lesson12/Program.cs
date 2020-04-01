using System;
using System.Collections.Generic;
using Task3.Figure;
using Task4.Items;
using Task4.Interfaces;
using Task4;

namespace lesson12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task3");
            var figures = new List<BaseFigure> { new Circle(15), new Rectangle(10, 80), new Square(10) };

            figures.ForEach(figure => figure.PrintInfo());
            Console.WriteLine("--------------");

            Console.WriteLine("tASK 4");
            var storage = new Storage();
            storage.Products.AddRange(new List<IInfo>
            {
                new Chair("Mebli"),
                new IronRaw(100),
                new WoodenRaw(500, "Oak"),
                new Chair("DreamChair")
            });
            storage.Products.ForEach(product => product.PrintInfo());
            Console.ReadLine();
        }
        
    }
}
