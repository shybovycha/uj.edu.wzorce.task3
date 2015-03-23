using System;

namespace task3
{
    public class ZwyklaFabryka : IPociagowaFabryka
    {
        private Random rand;

        public ZwyklaFabryka()
        {
            this.rand = new Random();
        }

        public ILokomotywa createElektrycznaLokomotywa()
        {
            return new ElektrycznaLokomotywa((rand.Next() % 95) + 5);
        }

        public ILokomotywa createSpalinowaLokomotywa()
        {
            return new SpalinowaLokomotywa((rand.Next() % 95) + 5);
        }

        public IWagon createTowarowyWagon()
        {
            return new TowarowyWagon((rand.Next() % 95) + 5);
        }

        public IWagon createOsobowyWagon()
        {
            return new OsobowyWagon((rand.Next() % 95) + 5);
        }
    }
}

