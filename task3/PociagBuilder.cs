using System;
using System.Collections.Generic;

namespace task3
{
    public class PociagBuilder
    {
        protected ILokomotywa lokomotywa;
        protected Dictionary<String, List<IWagon>> wagony;

        public PociagBuilder()
        {
            wagony = new Dictionary<String, List<IWagon>>();
            wagony["osobowe"] = new List<IWagon>();
            wagony["towarowe"] = new List<IWagon>();
        }

        public void addLokomotywe(ILokomotywa lokomotywa)
        {
            this.lokomotywa = lokomotywa;
        }

        public void addWagon(IWagon wagon)
        {
            if (wagon.isOsobowy())
                this.wagony["osobowe"].Add(wagon);
            else if (wagon.isTowarowy())
                this.wagony["towarowe"].Add(wagon);
        }

        public IPociag build()
        {
            Pociag res = new Pociag();

            res.setLokomotywa(this.lokomotywa);

            foreach (IWagon wagon in this.wagony["osobowe"]) {
                res.addWagon(wagon);
            }

            foreach (IWagon wagon in this.wagony["towarowe"]) {
                res.addWagon(wagon);
            }

            return res;
        }
    }
}

