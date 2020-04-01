using System;
using System.Collections.Generic;
using System.Text;
using Task4.Interfaces;

namespace Task4.Items
{
    public abstract class FurnitureBase : IInfo
    {
        public FurnitureBase(string manufactrure)
        {
            Manufactrure = manufactrure;
        }

        public abstract string FurnitureType { get; }

        public string Manufactrure { get; }

        public void PrintInfo()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"Furniture type is {FurnitureType} with manufacturer {Manufactrure}";
        }
    }
}
