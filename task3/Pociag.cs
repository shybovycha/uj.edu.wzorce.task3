using System;
using System.Collections.Generic;

namespace task3
{
    public class Pociag : IPociang
    {
        public Pociag()
        {
        }

        public virtual void setLokomotywa(ILokomotywa lokomotywa)
        {
            base.setLokomotywa(lokomotywa);
        }

        public virtual void addWagon(IWagon wagon)
        {
            base.addWagon(wagon);
        }
    }
}

