using System;
using System.Collections.Generic;
using System.Text;
using Task5.Interfaces;

namespace Task5.Flowers
{
    public class FlowersBase : IFlower
    {
        public FlowersBase(string color, decimal price)
        {
            Color = color;
            Price = price;
        }

        private string _name = "flower";
        private string _color = "unusual";
        private decimal _price = 0;

        public virtual string Name
        {
            get => _name;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    return;
                }
                _name = value;
            }
        }

        public virtual string Color
        {
            get => _color;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    return;
                }
                _color = value;
            }
        }

        public virtual decimal Price
        {
            get => _price;
            set
            {
                if (_price < 0)
                {
                    return;
                }
                _price = value;
            }
        }
    }
}
