using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Items
{
    public class Chair : FurnitureBase
    {
        public Chair(string manufacturer) : base(manufacturer)
        {
        }

        public override string FurnitureType => "Chair";
    }
}
