using System;

namespace task3
{
    public class TowarowyWagon : IWagon
    {
        public TowarowyWagon(int dlugosc) : base("towarowy", dlugosc)
        {
        }

        public virtual bool isTowarowy()
        {
            return true;
        }
    }
}

