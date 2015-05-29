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

        string m_wheelManufactureName;
        int m_bikeEngineVolume;

        public Bike(BikeLicenseType i_bikeLiensetype, int i_bikeEngineVolume, string i_wheelMaufactureName)
        {
            m_bikeEngineVolume = i_bikeEngineVolume;
            m_bikeLicenseType = i_bikeLiensetype;
            m_wheelManufactureName = i_wheelMaufactureName;
            
            //create wheel
            Vehicle.createWheels(2, m_wheelManufactureName  ,34);
            base("bike", i_licenceNumber, 8.0, new List)
        }

    }
}
