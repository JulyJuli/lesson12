using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    abstract public class Flower
    {
        public static int counter = 0;

        public Flower(string type, int price)
        {            
            Type = type;
            Price = price;
            Counter = counter++;
        }
        public string Type;
        public int Price;
        public int Counter;      
        
        public override string ToString()
        {
            return $"Name: {Type}, Price {Price}";
        }
    }
        
}
