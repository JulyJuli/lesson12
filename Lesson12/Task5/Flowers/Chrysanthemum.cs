using System;
using System.Collections.Generic;
using System.Text;

namespace Task5.Flowers
{
    public class Chrysanthemum : FlowersBase
    {
        public override string Name => "Chrysanthemum";

        public Chrysanthemum(string color, decimal price) : base(color, price)
        {
        }
    }
}
