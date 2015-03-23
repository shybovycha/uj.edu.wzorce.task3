using System;

namespace task3
{
    public class TowarowyOsiowyWagon : IOsiowyWagon
    {
        public TowarowyOsiowyWagon(int dlugosc) : base("towarowy", dlugosc)
        {
        }

        public override bool isTowarowy()
        {
            return true;
        }
    }
}

