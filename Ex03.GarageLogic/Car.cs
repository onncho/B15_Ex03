using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public enum CarColors 
    {
        Green,
        Black,
        White,
        Red
    }

    public enum CarDoorsNumber 
    {
        Two,
        Three,
        Four,
        Five
    }

    class Car : Vehicle
    {
        
        CarColors m_carColor;
        CarDoorsNumber m_carDoorsNumber;

        FuelType m_FuelCarType;
        
        // public Vehicle(String i_vehicleName, String i_licenceNumber, List<Wheel> i_vehicleWheels, Engine i_vehicleEngine)

        //Fuel Car
        //TODO Method that holds module name of the BIKE
        public Car(CarColors i_carColor, CarDoorsNumber i_carDoorNumber, string i_wheelMaufactureName, Engine i_engine, FuelType i_FuelCarType) 
            : base("fuel car", InitVehicleDB.generateLicenseNumber(), Vehicle.createWheels(4, i_wheelMaufactureName, 31), i_engine)
        {
            m_carColor = i_carColor;
            m_carDoorsNumber = i_carDoorNumber;
            
            if (i_FuelCarType == FuelType.Octan96)
            {
                m_FuelCarType = FuelType.Octan96;
                i_engine.maxAmountOfEnergy = 35;
            }
            else
            {
                //TODO ERROR
            }
        }

        //Electric car
        public Car(CarColors i_carColor, CarDoorsNumber i_carDoorNumber, string i_wheelMaufactureName, Engine i_engine, FuelType i_FuelCarType)
            : base("electric car", InitVehicleDB.generateLicenseNumber(), Vehicle.createWheels(4, i_wheelMaufactureName, 31), i_engine)
        {
            m_carColor = i_carColor;
            m_carDoorsNumber = i_carDoorNumber;

            if (i_FuelCarType == FuelType.Electric)
            {
                m_FuelCarType = FuelType.Electric;
                i_engine.maxAmountOfEnergy = (float) 2.2;
            }
            else
            {
                //TODO ERROR
            }
        }



    }
}
