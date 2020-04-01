using System;

namespace Task4
{
    public abstract class RawBase : IGoods
    {
        private double _volume = 1;
        public abstract string RawType { get; }


        public RawBase(double volume)
        {
            _volume = volume;
        }

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


        public void GetInfo()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"Raw type: {RawType}, volume: {Volume}.";
        }
    }
}
