using System;
using System.Collections.Generic;
using System.Text;

namespace Task5.Flowers
{
    public class Tulip :FlowersBase
    {
        public override string Name => "Tulip";

        public Tulip(string color, decimal price) : base(color, price)
        {
        }
    }
}
