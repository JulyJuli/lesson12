using System;
using Task4.Interfaces;

namespace Task4.Items
{
    abstract public class FurnitureBase : IInfo
    {
        public FurnitureBase(string manufacture)
        {
            Manufacture = manufacture;
        }

        public abstract string FurnitureType { get; }
        public string Manufacture {get; }

        public void PrintInfo()
        {
            Console.WriteLine(this);
        }
    }
}
