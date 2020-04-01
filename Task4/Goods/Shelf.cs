using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Shelf : FurnitureBase
    {
        public override string FurnitureType => "Shelf";
        public override string Manufacturer { get; set; }

        public Shelf(string manufacturer) : base(manufacturer)
        {
        }
    }
}
