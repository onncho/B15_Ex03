using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Bike : Vehicle 
    {
        public enum BikeLicenseType 
        { 
            A,
            A2,
            AB,
            B1 
        }

        private BikeLicenseType m_bikeLicenseType;

        private int m_bikeEngineVolume;

        public Bike(BikeLicenseType i_bikeLiensetype, int i_bikeEngineVolume, string i_wheelMaufactureName, string i_bikeLicenseNumber, Engine i_engine, bool i_isElectric) 
            : base("bike", i_bikeLicenseNumber, i_engine.maxAmountOfEnergy, i_engine.maxAmountOfEnergy,
            i_isElectric ?  Vehicle.createWheels(2, i_wheelMaufactureName, 31) : Vehicle.createWheels(2, i_wheelMaufactureName, 34), i_engine)
        {
            m_bikeEngineVolume = i_bikeEngineVolume;
            m_bikeLicenseType = i_bikeLiensetype;
        }
    }
}
