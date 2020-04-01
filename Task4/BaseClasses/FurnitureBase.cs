using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public abstract class FurnitureBase : IGoods
    {    
        public abstract string FurnitureType { get; }
        public abstract string Manufacturer { get; set; }


        public FurnitureBase(string manufacturer)
        {
            Manufacturer = manufacturer;
        }


        public void GetInfo()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"Furniture type: {FurnitureType}, manufacturer: {Manufacturer}.";
        }
    }
}
