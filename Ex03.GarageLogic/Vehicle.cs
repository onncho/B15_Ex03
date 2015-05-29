using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class Vehicle
    {
        private float m_reaminingEng;
        private String m_vehicleName, m_licenceNumber;
        private List<Wheel> m_vehicleWheels;
        private Engine m_vehicleEngine;


        public Vehicle(String i_vehicleName, String i_licenceNumber, float i_reaminingEng, float i_maxEnergy, List<Wheel> i_vehicleWheels, Engine i_vehicleSystem)
        {
            this.m_vehicleName = i_vehicleName;
            this.m_licenceNumber = i_licenceNumber;
            this.m_reaminingEng = i_reaminingEng;
            this.m_vehicleWheels = i_vehicleWheels;
            m_vehicleEngine = i_vehicleSystem;
        }

        public float ReaminingEng
        {
            get { return m_reaminingEng; }
            set { m_reaminingEng = value; }
        }

        internal List<Wheel> VehicleWheels
        {
            get { return m_vehicleWheels; }
            set { m_vehicleWheels = value; }
        }

        public String VehicleName
        {
            get { return m_vehicleName; }
            set { m_vehicleName = value; }
        }

        public String LicenceNumber
        {
            get { return m_licenceNumber; }
            set { m_licenceNumber = value; }
        }


        public static createWheels()
    }
}
