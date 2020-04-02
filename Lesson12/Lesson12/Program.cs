using System;
using System.Collections.Generic;
using Task_4;
using Task_4.Interfaces;
using Task1;
using Task3.Figures;
using Task2;
using Task5;

namespace Lesson12
{
    class Program
    {
        public static double GetAverageArea(Trapezoid[]array)
        {
            double averageArea = 0;
            double sumAreas = 0;
            int countTrapezoids = array.Length;
            for(int i=0; i<array.Length; i++)
            {
                sumAreas += array[i].Area;
            }
            averageArea = sumAreas / countTrapezoids;
            return averageArea; 
        }

        public static int GetCountSmallTrapezoids(Trapezoid[]array)
        {
            int countSmallTrapezoids = 0;
            double averageArea=GetAverageArea(array);
            for (int i= 0; i < array.Length; i++)
            {
                if(array[i].Area<averageArea)
                {
                    countSmallTrapezoids++;
                }
            }
            return countSmallTrapezoids;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Task 3");
            var figures = new List<BaseFigure> { new Task3.Figures.Circle(15), new Rectangle(10, 12.3), new Square(4.85) };
            figures.ForEach(figure => figure.PrintOnfo());
            Console.WriteLine("---------------------------");

            Console.WriteLine("Task 4");
            var storage = new Storage();
            storage.Products.AddRange(new List<IInfo> { new Chair("Mebli"),
                new IronRaw(100),
                new WoodenRaw(500, "Oak"),
                new Chair("DreamChair") });
            storage.Products.ForEach(product => product.PrintInfo());
            Console.WriteLine("---------------------------");

            Console.WriteLine("Task 1");
            Trapezoid[] array = new Trapezoid[]{ new Trapezoid(new Point(1,1), new Point(5,3), new Point(9,3), new Point(12,1)),
                new Trapezoid(new Point(2, 2), new Point(7, 3), new Point(9, 3), new Point(12, 2)),
                new Trapezoid(new Point(1, 5), new Point(4, 8), new Point(7, 8), new Point(10, 5)),
                new Trapezoid(new Point(21, 17), new Point(25, 23), new Point(29, 23), new Point(33, 17)),
                new Trapezoid(new Point(47, 15), new Point(52, 50), new Point(57, 50), new Point(85, 15)) };
           
            for (int i=0; i<array.Length; i++)
            {
                int numberTrapezoid = i+1;
                array[i].PrintInfo(numberTrapezoid);
            }
            Console.WriteLine($"AverageArea is {GetAverageArea(array)}");
            Console.WriteLine($"Count of trapezoids, which area less then AverageArea is {GetCountSmallTrapezoids(array)}");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Task 2");
            //С использованием построенного класса создайте две окружности: одну с центром в (0;0) и радиусом 12, а вторую с центром в(3;5)
            //и радиусом 11. Проверьте с помощью созданного метода равна ли их площадь и если равна, то выведите соответсвующее сообщение 
            //на экран.
            var circle1 = new Task2.Circle(new Point(0, 0), 12);
            var circle2 = new Task2.Circle(new Point(3, 5), 11);

            var circle3 = new Task2.Circle(new Point(7, 3), 7.35);
            var circle4 = new Task2.Circle(new Point(3, 12), 7.35);
            Console.WriteLine(Task2.Circle.CompareTwoCircles(circle1, circle2));
            Console.WriteLine(Task2.Circle.CompareTwoCircles(circle3, circle4));
            Console.WriteLine("---------------------------");

            Console.WriteLine("Task 5");
            //var rose = new Rose();
            //var carnation = new Carnation();
            //var tulip = new Tulips();
            //Console.WriteLine(rose.ToString());

            var myBouquet1 = new Bouquet();
            myBouquet1.ToPickUpBouquet(new List<Flower>() { new Carnation(), new Carnation(), new Carnation(), new Tulips(),
                new Tulips(), new Tulips(),new Rose(),new Rose(),new Rose() });
            myBouquet1.GetCostOfBouqet();

            var myBouquet2 = new Bouquet();
            myBouquet2.ToPickUpBouquet(new List<Flower>() { new Carnation(17.50M), new Carnation(17.98M), new Carnation(16.50M), new Tulips(),
                new Tulips(12.50M), new Tulips(20.90m),new Rose(45),new Rose(35.50m),new Rose(28.80M) });
            myBouquet2.GetCostOfBouqet();
            //myBouquet.PrintCost1();


        }
    }
}
