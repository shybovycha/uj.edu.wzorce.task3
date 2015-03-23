using System;

namespace task3
{
    public class OsiowaFabryka : IPociagowaFabryka
    {
        private Random rand;

        public OsiowaFabryka()
        {
            this.rand = new Random();
        }

        public ILokomotywa createElektrycznaLokomotywa()
        {
            return new ElektrycznaOsiowaLokomotywa((rand.Next() % 95) + 5);
        }

        public ILokomotywa createSpalinowaLokomotywa()
        {
            return new SpalinowaOsiowaLokomotywa((rand.Next() % 95) + 5);
        }

        public IWagon createTowarowyWagon()
        {
            return new TowarowyOsiowyWagon((rand.Next() % 95) + 5);
        }

        public IWagon createOsobowyWagon()
        {
            return new OsobowyOsiowyWagon((rand.Next() % 95) + 5);
        }
    }
}

