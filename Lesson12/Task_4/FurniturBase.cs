using System;
using Task_4.Interfaces;

namespace Task_4
{
    public abstract class FurnitureBase : IInfo
    {
        public FurnitureBase(string manufacture)
        {
            Manufacture = manufacture;
        }

        public abstract string FurnitureType { get; }
        public string Manufacture { get; }
        public void PrintInfo()
        {
            Console.WriteLine(this); ;
        }

        public override string ToString()
        {
            return $"Furniture is {FurnitureType} with manufacturer {Manufacture}";
        }
    }
}
