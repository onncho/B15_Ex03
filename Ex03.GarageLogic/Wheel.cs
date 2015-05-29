using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class Wheel
    {

        private string m_manufactureName;
        private float m_currentAirPressure;
        private float m_maxAirPressure;


        public Wheel(string i_manufactureName, float i_currentAirPressure, float i_maxAirPressure)
        {
            this.m_manufactureName = i_manufactureName;
            this.m_currentAirPressure = i_currentAirPressure;
            this.m_maxAirPressure = i_maxAirPressure;
        }


        public float addPressure(float pressureToAdd)
        {
            float returnPressure = 0;

            
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


        public string getWheelName()
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
