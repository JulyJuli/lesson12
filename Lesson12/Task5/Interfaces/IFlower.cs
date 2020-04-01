using System;
using System.Collections.Generic;
using System.Text;

namespace Task5.Interfaces
{
    public interface IFlower
    {
        string Name { get; set; }
        string Color { get; set; }
        decimal Price { get; set; }
    }
}
