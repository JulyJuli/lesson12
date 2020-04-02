using System;
using Task4.Interfaces;

namespace Task4.Items
{
    public abstract class RawBase : IInfo
    {
        private double _volume = 1;

        public RawBase(double volume)
        {
            Volume = volume;
        }
        
        public abstract string RawType { get; }

        public double Volume
        {
            get => _volume;
            set
            {
                if (value > 0)
                {
                    _volume = value;
                }
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"Raw type {RawType} with volume {Volume}";
        }
    }
}