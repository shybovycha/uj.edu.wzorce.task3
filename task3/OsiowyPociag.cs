using System;

namespace task3
{
    public class OsiowyPociag : IPociag
    {
        public OsiowyPociag()
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

