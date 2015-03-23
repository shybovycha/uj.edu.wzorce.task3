using System;
using System.Collections.Generic;

namespace task3
{
    public class Pociag : IPociag
    {
        public Pociag() : base()
        {
        }

        public override void setLokomotywa(ILokomotywa lokomotywa)
        {
            this.lokomotywa = lokomotywa;
        }

        public override void addWagon(IWagon wagon)
        {
            this.wagony.Add(wagon);
        }
    }
}

