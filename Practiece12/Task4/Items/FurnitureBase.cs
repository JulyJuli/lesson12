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
        public abstract string FurnitureType { get; }
        public string Manufacture { get; }
        public virtual void PrintInfo()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"Furniture type is {FurnitureType} ";
        }
    }
}
