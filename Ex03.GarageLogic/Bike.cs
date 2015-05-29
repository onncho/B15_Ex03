﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class Bike : Vehicle 
    {
        enum BikeLicenseType { A, A2, AB, B1 };
        BikeLicenseType m_bikeLicenseType;

        int m_bikeEngineVolume;

        public Bike(BikeLicenseType i_bikeLiensetype, int i_bikeEngineVolume, string i_wheelMaufactureName, string i_bikeLicenseNumber, Engine i_engine) 
            : base("bike", i_bikeLicenseNumber, 8.0, 8.0, Vehicle.createWheels(2, i_wheelMaufactureName, 34), i_engine)
        {
            m_bikeEngineVolume = i_bikeEngineVolume;
            m_bikeLicenseType = i_bikeLiensetype;
            
            //create wheel
            
        }

    }
}