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
        struct carReport
        {
            private Vehicle vec;
            private string ownerName;
            private string ownerPhone;
            private VehicleStatus status;
            private string license;

            public void initStruct(Vehicle i_vehicle, string i_ownerName, string i_ownerPhone, string i_license)
            {
                vec = i_vehicle;
                ownerName = i_ownerName;
                ownerPhone = i_ownerPhone;
                status = VehicleStatus.inFix;
                license = i_license;
            }


            public Vehicle getVehicle
            {
                get { return vec; }
            }

            public string getOwnerName()
            {
                return ownerName;
            }

            public string getOwnerPhone()
            {
                return ownerPhone;
            }
            
            public VehicleStatus changeStatus
            {
                get { return status; }
                set { status = value; }
            }

            public string getSetLicense
            {
                get { return license; }
                set { license = value; }
            }

        };

        // define collections for vehicles status
        Dictionary<string, carReport> m_listOfReports;
        public Garage()
        {
            m_listOfReports = new Dictionary<string, carReport>();
        }

        public void insertVehicleToGarage(string i_licenseNumber, VehicleStatus i_vehicleNewStatus, Vehicle i_toAdd, string i_ownerName, string i_ownerPhone)
        {
            carReport carToAdd = new carReport();
            carToAdd.initStruct(i_toAdd, i_ownerName, i_ownerPhone, i_licenseNumber);

            bool isVehicaleExist = this.m_listOfReports.ContainsKey(i_licenseNumber);
            if (isVehicaleExist)
            {
            }
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
