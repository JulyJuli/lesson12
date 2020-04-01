using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Chair : FurnitureBase
    {
        public override string Manufacturer { get; set; }
        public override string FurnitureType => "Chair";


        public Chair(string manufacturer) : base(manufacturer)
        {
        }
    }
}
