using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    
    public class Shop
    {
        public Shop()
        {
            Goods = new List<IGoods>();
        }
        public List<IGoods> Goods { get; set; }
    }

}
