using System;
using System.Collections.Generic;
using Task5.Interfaces;

namespace Task5
{
    public class Bouquet
    {
        public Bouquet()
        {
            Flowers = new List<IFlower>();
        }

        public List<IFlower> Flowers { get; set; }
    }
}
