using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class Bike : Vehicle 
    {
        enum BikeLicenseType { A, A2, AB, B1 };
        BikeLicenseType m_bikeLicenseType;

        int m_bikeEngineVolume;

        public Bike(BikeLicenseType i_bikeLiensetype, int i_bikeEngineVolume)
        {
            m_bikeEngineVolume = i_bikeEngineVolume;
            m_bikeLicenseType = i_bikeLiensetype;
        }

    }
}
