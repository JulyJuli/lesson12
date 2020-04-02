using System;
using Task4.Interfaces;

namespace Task4.Items
{
    public abstract class FurnitureBase : IInfo
    {
        public FurnitureBase(string manufacture)
        {
            
            Manufacture = manufacture;
        }

        public void PrintInfo()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"Furniture type {FurnitureType} with manufacture {Manufacture}";
        }

        public abstract string FurnitureType { get; }

        public string Manufacture { get; }
    }
}