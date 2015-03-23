using System;

namespace task3
{
    public abstract class ILokomotywa
    {
        protected String type;
        protected int dlugosc;

        public ILokomotywa(String type, int dlugosc)
        {
            this.type = type;
            this.dlugosc = dlugosc;
        }

        public String prezentujSie()
        {
            return String.Format("Jestem {0} lokomotywą o długości {1}", this.type, this.dlugosc);
        }
    }
}

