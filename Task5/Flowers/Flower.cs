using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Flowers
{
    public abstract class Flower
    {
        protected abstract string FlowerType { get; }

        public abstract int Price { get; }

        public override string ToString()
        {
            return $"{FlowerType}, {Price} UAH";
        }
    }
}
