using System;
using System.Collections.Generic;

namespace task3
{
    public abstract class IPociang
    {
        protected ILokomotywa lokomotywa;

        private List<IWagon> osoboweWagony;
        private List<IWagon> towaroweWagony;

        public IPociang()
        {
        }

        protected virtual void setLokomotywa(ILokomotywa lokomotywa)
        {
            this.lokomotywa = lokomotywa;
        }

        public ILokomotywa getLokomotywa()
        {
            return this.lokomotywa;
        }

        protected virtual void addWagon(IWagon wagon)
        {
            if (wagon.isTowarowy())
                this.towaroweWagony.Add(wagon);
            else if (wagon.isOsobowy())
                this.osoboweWagony.Add(wagon);
        }

        public List<IWagon> getWagony()
        {
            List<IWagon> res = new List<IWagon>();

            res.AddRange(this.osoboweWagony);
            res.AddRange(this.towaroweWagony);

            return res;
        }

        public String prezentujSie()
        {
            String result = "";

            result += this.lokomotywa.prezentujSie();

            foreach (IWagon wagon in this.getWagony()) {
                result += ";" + wagon.prezentujSie();
            }

            return result;
        }
    }
}

