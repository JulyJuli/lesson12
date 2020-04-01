using System;
using System.Collections.Generic;
using System.Text;

namespace Task4.Items
{
    public class Chair : FurnitureBase
    {
        public Chair(string manufactrure) : base (manufactrure)
        {
            
        }

        public override string FurnitureType => "Chair";
    }
}
