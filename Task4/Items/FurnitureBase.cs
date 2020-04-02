using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.Interfaces;

namespace Task4.Items
{
    public abstract class FurnitureBase : IInfo
    {
        public FurnitureBase(string manufacturer)
        {
            Manufacturer = manufacturer;
        }

        public abstract string FurnitureType { get; }

        public string Manufacturer { get; }

        public void PrintInfo()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"Furniture type is {FurnitureType}, manufacturer is {Manufacturer}";
        }
    }
}
