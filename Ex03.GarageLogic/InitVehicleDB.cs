using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class InitVehicleDB
    {
        private int k_numberOfVehicles = 10;

        private List<Vehicle> m_listOfVehicles;



        public static string generateLicenseNumber()
        {
            return "ABCD123";
        }

        public static string generateOwnerName()
        {
            return "TestOwner";
        }

        public static string generatePhoneNumber()
        {
            return "050000000";
        }

    }
}
