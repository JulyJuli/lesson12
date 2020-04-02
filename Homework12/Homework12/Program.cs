using System;
using System.Collections.Generic;
using Task2;
using Task5.Flowers;

namespace Homework12
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Task1: ");

            var trapeze = new List<Trapeze> {
                new Trapeze(-4, 0, -2, 4, 2, 4, 4, 0),
                new Trapeze(-6, 5, -2, 4, 2, 4, 6, 5),
                new Trapeze(1, -2, -1, -1, -1, 1, 1, 2),
                new Trapeze(3, -5, 6, 4, 10, 4, 13, -5),
                new Trapeze(3, -5, 6, 4, 10, 4, 20, -5)

            };
            trapeze.ForEach(points => points.PrintInfo());
            Console.WriteLine($"\nSumArea: {Trapeze.SumArea(trapeze):F3}");
            //Trapeze.SumArea(trapeze);
            int counter = 0;
            double sumArea = Trapeze.SumArea(trapeze);
            double mean = sumArea /trapeze.Count;

            for (int i = 0; i < trapeze.Count; i++)
            {
                if(trapeze[i].GetArea()>mean)
                {
                    counter++;
                }
            }
            Console.WriteLine($"\nMean: {mean:F3} \nCounter trapeze whose has area more than mean: {counter}");



            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Task2: ");

            var circleFirst = new CircleFirst(12, 0, 0);
            var circleSecond = new CircleSecond(11, 3, 5);
            var areaCircleFirst = circleFirst.GetArea();
            var areaCircleSecond = circleSecond.GetArea();
            Console.WriteLine($"\nCircle first: \n{circleFirst.PrintInfo()}, \nCircle second: \n{circleSecond.PrintInfo()}," +
                $"\nArea circle first {areaCircleFirst:F3}, \narea circle second {areaCircleSecond:F3}," +
                $"\n{Circle.EqualAreasCheck(areaCircleFirst, areaCircleSecond):F3}");

            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("Task5");
            var bouquet = new List<Flowers>()
            {
                new Roses(),
                new Carnations(),
                new Tulips(),
                new Tulips()
            };
            bouquet.ForEach(flowers => flowers.PrintInfo());
            Console.WriteLine($"Price this bouquet: {Flowers.FindingPriceOfBouquet(bouquet):F3}");


            Console.ReadLine();

        }
    }
}