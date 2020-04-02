using System;
using Task5.Interfaces;

namespace Task5.Items
{
    public abstract class FlowerBase : IFlowerInfo
    {
        private int _price = 0;
        public abstract string FlowerType { get; }
        
        public int Price
        {
            get => _price;
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }

        public string Color { get; }
        
        public FlowerBase(string color)
        {
            
            Color = color;
        }
        
        public void PrintInfo()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"Flower type {FlowerType} with color {Color} and price {Price}.";
        }
    }
}