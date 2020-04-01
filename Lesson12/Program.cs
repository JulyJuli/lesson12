using System;
using System.Collections.Generic;
using System.Linq;
using Task1;
using Task1.BaseClasses;
using Task2;
using Task3.Figures;
using Task4;
using Task5;
using Task5.Flowers;

namespace Lesson12
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            List<Trapeze> trapezes = new List<Trapeze>
            {
                new Trapeze(new Point(0,0), new Point(1,3), new Point (3,3), new Point (4,0))                ,
                new Trapeze(new Point(0,1), new Point(1,4), new Point (3,4), new Point (4,1)),
                new Trapeze(new Point(0,0), new Point(1,10), new Point (5,10), new Point (12,0))
            };

            double averageArea = trapezes.Sum(fig => fig.GetArea()) / trapezes.Count;
            int counter = 0;

            foreach (var fig in trapezes)
            {
                Console.Write($"Trapeze #{++counter} is " + (fig.IsIsoscelles() ? "isoscelles" : "non-isoscelles"));
                Console.WriteLine($", perimeter: {fig.GetPerimeter():F2}, area: {fig.GetArea():F2}. ");
            }

            Console.WriteLine(trapezes.GroupBy((i) => (i.GetArea() > averageArea)).Count() + " trapezes has an area, greater than average.");
            Console.WriteLine("________________________");


            Console.WriteLine("Task 2");
            Sheet sheet = new Sheet();
            sheet.AddCircles(new Task2.Circle(0, 0, 5), new Task2.Circle(2, 2, 5), new Task2.Circle(3, 3, 5.1));
            foreach (Task2.Circle circle in sheet)
            {
                Console.WriteLine($"Circle #{sheet.IndexOf(circle) + 1} - center: {circle.CenterPoint.CoordinateX},{circle.CenterPoint.CoordinateY}; radius: {circle.Radius}.");
            }

            Console.WriteLine(sheet.AreasCompare(sheet[0], sheet[1]));
            Console.WriteLine(sheet.AreasCompare(sheet[1], sheet[2]));
            Console.WriteLine("________________________");


            Console.WriteLine("Task 3");
            var figures = new List<BaseFigure>
            {
                new Task3.Figures.Circle(10),
                new Rectangle(5, 6),
                new Square(3),
            };

            figures.ForEach(figure => figure.PrintInfo());
            Console.WriteLine("________________________");


            Console.WriteLine("\n\nTask 4");

            Shop shop = new Shop();
            shop.Goods.AddRange(new List<IGoods>
            {
                new Chair ("Mebli"),
                new Shelf("AC-DC"),
                new IronRaw(12),
                new Wood("Birch tree",50)
            });

            shop.Goods.ForEach(good => good.GetInfo());
            Console.WriteLine("________________________");


            Console.WriteLine("\n\nTask 5");

            Bouquet bouquet = new Bouquet("Bill Jonson");
            bouquet.AddRange(new Sunflower(), new Chamomile(), new Buttercup(), new Buttercup(), new Sunflower());

            Console.WriteLine(bouquet.GetInfo());
            Console.WriteLine("________________________");


            Console.Read();
        }
    }
}
