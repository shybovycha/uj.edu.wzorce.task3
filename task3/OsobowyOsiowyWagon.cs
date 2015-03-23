using System;

namespace task3
{
    public class OsobowyOsiowyWagon : IOsiowyWagon
    {
        public OsobowyOsiowyWagon(int dlugosc) : base("osobowy", dlugosc)
        {
        }

        public override bool isOsobowy()
        {
            return true;
        }
    }
}

