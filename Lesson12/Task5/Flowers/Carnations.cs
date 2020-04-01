using System;
using System.Collections.Generic;
using System.Text;

namespace Task5.Flowers
{
    public class Carnations : FlowersBase
    {
        public override string Name => "Cactus";

        public Carnations(string color, decimal price) : base(color, price)
        {
        }
    }
}
