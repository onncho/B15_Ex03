using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public enum BikeLicenseType 
    { A,
      A2,
      AB,
      B1 
    }
    class Bike : Vehicle 
    {
        BikeLicenseType m_bikeLicenseType;

        int m_bikeEngineVolume;
        FuelType m_FuelBikeType;
        
        // public Vehicle(String i_vehicleName, String i_licenceNumber, List<Wheel> i_vehicleWheels, Engine i_vehicleEngine)

        //Fuel Bike
        //TODO Method that holds module name of the BIKE
        public Bike(BikeLicenseType i_bikeLiensetype, int i_bikeEngineVolume, string i_wheelMaufactureName, Engine i_engine, FuelType i_FuelBikeType) 
            : base("fuel bike", InitVehicleDB.generateLicenseNumber(), Vehicle.createWheels(2, i_wheelMaufactureName, 34), i_engine)
        {
            m_bikeEngineVolume = i_bikeEngineVolume;
            m_bikeLicenseType = i_bikeLiensetype;
            if (i_FuelBikeType == FuelType.Octan98)
            {
                m_FuelBikeType = FuelType.Octan98;
                i_engine.maxAmountOfEnergy = 8;
            }
            else
            {
                //TODO ERROR
            }
        }

        //Electric Bike
        public Bike(BikeLicenseType i_bikeLiensetype, int i_bikeEngineVolume, string i_wheelMaufactureName, Engine i_engine, FuelType i_fuelBikeType)
            : base("electric bike", InitVehicleDB.generateLicenseNumber(), Vehicle.createWheels(2, i_wheelMaufactureName, 31), i_engine)
        {
            m_bikeEngineVolume = i_bikeEngineVolume;
            m_bikeLicenseType = i_bikeLiensetype;

            if (i_fuelBikeType == FuelType.Electric)
            {
                m_FuelBikeType = FuelType.Electric;
                i_engine.maxAmountOfEnergy = (float) 1.2;
            }
            else
            {
                //TODO ERROR IN CONSTRUCTOR
            }
        }

    }
}
