using System;
using Task4.Interfaces;

namespace Task4.Items
{
    public abstract class RawBase : IInfo
    {

        public RawBase(double volume)
        {
            Volume = volume;
        }


        private double _volume;

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

        public abstract string RawType { get; }

        public virtual void PrintInfo()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"Raw type is {RawType} with volume {Volume}";
        }
    }
}
