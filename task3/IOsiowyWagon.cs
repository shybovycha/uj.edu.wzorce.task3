using System;

namespace task3
{
    public abstract class IOsiowyWagon : IWagon
    {
        protected int osi;

        public IOsiowyWagon(String type, int dlugosc) : base(type, dlugosc)
        {
            this.osi = Math.Max(2, this.dlugosc / 20);
        }

        public override String prezentujSie()
        {
            return String.Format("{0} i mam {1} osi", base.prezentujSie(), this.osi);
        }
    }
}

