using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Interfaces
{
    public interface IFlower
    {
        string GetFlowerInfo();
        string GetFlowerSort();
        decimal GetPrice();
        void SetPrice(decimal newPrice);


    }
}
