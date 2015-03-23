using System;

namespace task3
{
    public abstract class IWagon
    {
        protected int dlugosc;
        protected String type;

        public IWagon(String type, int dlugosc)
        {
            this.type = type;
            this.dlugosc = dlugosc;
        }

        public virtual bool isOsobowy()
        {
            return false;
        }

        public virtual bool isTowarowy()
        {
            return false;
        }

        public virtual String prezentujSie()
        {
            return String.Format("Jestem {0} wagon o długości {1}", this.type, this.dlugosc);
        }
    }
}

