using System;
using System.Collections.Generic;

namespace task3
{
    public abstract class IPociag
    {
        protected ILokomotywa lokomotywa;

        protected List<IWagon> wagony;

        public IPociag()
        {
            this.wagony = new List<IWagon>();
        }

        public abstract void setLokomotywa(ILokomotywa lokomotywa);

        public ILokomotywa getLokomotywa()
        {
            return this.lokomotywa;
        }

        public abstract void addWagon(IWagon wagon);

        public List<IWagon> getWagony()
        {
            return this.wagony;
        }

        public String prezentujSie()
        {
            String result = "";

            result += this.lokomotywa.prezentujSie();

            foreach (IWagon wagon in this.getWagony()) {
                result += "\n" + wagon.prezentujSie();
            }

            return result;
        }
    }
}

