﻿using System;
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

        private string m_ownerName;
        private string m_ownerPhoneNumber;

        public Vehicle(String i_vehicleName, String i_licenceNumber, List<Wheel> i_vehicleWheels, 
            Engine i_vehicleEngine)
        {
            m_vehicleName = i_vehicleName;
            m_licenceNumber = i_licenceNumber;
            m_vehicleWheels = i_vehicleWheels;
            m_vehicleEngine = i_vehicleEngine;

            m_reaminingEng = i_vehicleEngine.maxAmountOfEnergy - i_vehicleEngine.currentAmountOfEnergy;
            
            m_ownerName = InitVehicleDB.generateOwnerName();
            m_ownerPhoneNumber = InitVehicleDB.generatePhoneNumber();
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

        public Engine getEngine
        {
            get { return m_vehicleEngine; }
        }

        public static List<Wheel> createWheels(int i_numberOfWheels, string io_manufactureName, float io_maxAirPressure)
        {
            List<Wheel> vehicleWheels = new List<Wheel>();
            for (int i = 0; i < i_numberOfWheels; i++)
            {
                vehicleWheels.Add(new Wheel(io_manufactureName, io_maxAirPressure, io_maxAirPressure));
            }

            return vehicleWheels;
        }
    }
}
