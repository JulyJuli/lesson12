using System;
using Task_4.Interfaces;

namespace Task_4
{
    public abstract class RawBase : IInfo
    {
        private
             double _volume = 1;

        public RawBase(double volume)
        {
            Volume = volume;
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

        public abstract string RawType { get; }
        public void PrintInfo()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"Raw type is {RawType} with volume {Volume}"; ;
        }
    }
}
