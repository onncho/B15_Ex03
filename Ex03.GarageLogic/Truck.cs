using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class Truck : Vehicle
    {
        float m_currentCarryingWeight;
        bool v_isCarringToxics;

        FuelType m_FuelCarType;
        
        // public Vehicle(String i_vehicleName, String i_licenceNumber, List<Wheel> i_vehicleWheels, Engine i_vehicleEngine)

        //TODO Method that holds module name of the Truck
        public Truck(float i_currentCarringWeight, bool i_isCarringToxics, string i_wheelMaufactureName, Engine i_engine, FuelType i_FuelCarType) 
            : base("truck", InitVehicleDB.generateLicenseNumber(), Vehicle.createWheels(16, i_wheelMaufactureName, 25), i_engine)
        {
            m_currentCarryingWeight = i_currentCarringWeight;
            v_isCarringToxics = i_isCarringToxics;
            
            if (i_FuelCarType == FuelType.Soler)
            {
                m_FuelCarType = FuelType.Soler;
                i_engine.maxAmountOfEnergy = 170;
            }
            else
            {
                //TODO ERROR
            }
        }
    }
}
