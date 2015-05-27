using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class Wheel
    {

        private String m_manufactureName;
        private float m_currentAirPressure;
        private float m_maxAirPressure;


        public Wheel(String m_manufactureName, float m_currentAirPressure, float m_maxAirPressure)
        {
            this.m_manufactureName = m_manufactureName;
            this.m_currentAirPressure = m_currentAirPressure;
            this.m_maxAirPressure = m_maxAirPressure;
        }


        public float addPressure(float pressureToAdd)
        {
            float returnPressure = 0;

            //check if the pressure already in Maxs
            if (m_currentAirPressure == m_maxAirPressure) {
                returnPressure = m_maxAirPressure;
            }

            returnPressure = m_currentAirPressure + pressureToAdd;

            //check if the pressure extended the range
            if (returnPressure > m_maxAirPressure)
            {
                //TODO add exception
                System.Console.WriteLine("Error: Too much pressure to add");
            }

            return returnPressure;
        }


        public String getWheelName()
        {
            return this.m_manufactureName;
        }

        public float getCurrentAirPressure()
        {
            return this.m_currentAirPressure;
        }

        public float getMaxAirPressure()
        {
            return this.m_maxAirPressure;
        }

    }
}
