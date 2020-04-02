using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Flowers
{
    public class Rose : Flower
    {
        public override int Price => 60;

        protected override string FlowerType => "Rose";
    }
}
