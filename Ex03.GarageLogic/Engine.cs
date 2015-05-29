using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class Engine
    {
        private float m_maxAmountOfEnergyType,
                      m_currentAmountOfEnergyType;

        public Engine(float i_maxAmount, float i_currentAmount) 
        {
            m_maxAmountOfEnergyType = i_maxAmount;
            m_currentAmountOfEnergyType = i_currentAmount;
        }


        public bool fuelUpEnergy(float amountToFuel)
        {
            bool energyUnderCapacity = m_currentAmountOfEnergyType + amountToFuel <= m_maxAmountOfEnergyType;

            if (energyUnderCapacity) 
            {
                fuelOperation(amountToFuel);
            }

            //TODO = ERROR
            return energyUnderCapacity;
        }

        private void fuelOperation(float i_amountToFuel) 
        {
            m_currentAmountOfEnergyType += i_amountToFuel;
        }

    }
}
