using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Flowers
{
    public class Clove : Flower
    {
        public override int Price => 30;

        protected override string FlowerType => "Clove";
    }
}
