﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Flowers
{
    public class Tulip : Flower
    {
        public override int Price => 25;

        protected override string FlowerType => "Tulip";
    }
}
