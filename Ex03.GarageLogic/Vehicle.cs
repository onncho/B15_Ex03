using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    // need to put here arguments but who gonna give it? 
    class Vehicle : Wheel(//HERE//)
    {

        private String m_vehicleName;
        private String m_licenceNumber;
        private float m_reaminingEng;
        private List<Wheel> m_vehicleWheels;

        public Vehicle(String m_vehicleName, String m_licenceNumber, float m_reaminingEng, List<Wheel> m_vehicleWheels)
        {
            this.m_vehicleName = m_vehicleName;
            this.m_licenceNumber = m_licenceNumber;
            this.m_reaminingEng = m_reaminingEng;
            this.m_vehicleWheels = m_vehicleWheels;

        }


    }
}
