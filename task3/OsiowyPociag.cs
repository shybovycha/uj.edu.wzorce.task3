using System;

namespace task3
{
    public class OsiowyPociag : IPociang
    {
        public OsiowyPociag()
        {
        }

        public virtual void setLokomotywa(IOsiowaLokomotywa lokomotywa)
        {
            base.setLokomotywa(lokomotywa);
        }

        public virtual void addWagon(IOsiowyWagon wagon)
        {
            base.addWagon(wagon);
        }
    }
}

