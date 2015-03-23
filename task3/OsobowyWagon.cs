using System;

namespace task3
{
    public class OsobowyWagon : IWagon
    {
        public override bool isOsobowy()
        {
            return true;
        }

        public OsobowyWagon(int dlugosc) : base("osobowy", dlugosc)
        {
        }
    }
}

