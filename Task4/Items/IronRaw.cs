using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Items
{
    public class IronRaw : RawBase
    {
        public IronRaw(double volume) : base(volume)
        {          
        }

        public override string RawType => "Iron";
    }
}
