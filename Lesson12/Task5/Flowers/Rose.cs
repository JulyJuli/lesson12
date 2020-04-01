using System;
using System.Collections.Generic;
using System.Text;

namespace Task5.Flowers
{
    public class Rose : FlowersBase
    {
        public override string Name => "Rose";

        public Rose(string color, decimal price) : base(color, price)
        {
        }
    }
}
