using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex03.GarageLogic
{
     public enum VehicleStatus
        {
            inFix,
            Fixed,
            Paid
        }

    class Garage
    {
        
        // define collections for vehicles status
        private List<Vehicle> m_inFixList;
        private List<Vehicle> m_fixedList;
        private List<Vehicle> m_paidList;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i_licenseNumber"></param>
        /// <param name="i_vehicleNewStatus"></param>
        public void insertVehicleToGarage(string i_licenseNumber, VehicleStatus i_vehicleNewStatus)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i_vehicle"></param>
        public void changeVehicleStatus(Vehicle i_vehicle)
        {

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="i_licenseNumber"></param>
        public void fillupAirPressure(string i_licenseNumber)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i_licenseNumber"></param>
        /// <param name="i_fuelType"></param>
        public void fuelUpFuelVehicle(string i_licenseNumber, FuelType i_fuelType)
        {

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="i_licenseNumber"></param>
        /// <param name="i_timeToCharge"></param>
        public void chargeUpElectricVehicle(string i_licenseNumber, int i_timeToCharge)
        {

        }

    }
}
