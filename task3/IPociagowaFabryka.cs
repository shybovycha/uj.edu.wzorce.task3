using System;

namespace task3
{
    public interface IPociagowaFabryka
    {
        IWagon createTowarowyWagon();

        IWagon createOsobowyWagon();

        ILokomotywa createElektrycznaLokomotywa();

        ILokomotywa createSpalinowaLokomotywa();
    }
}

