using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class System
    {
        private float m_maxAmountOfEnergyType,
            m_currentAmountOfEnergyType;

        public System(float i_maxAmount, float i_currentAmount) 
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

            return energyUnderCapacity;
        }

        private void fuelOperation(float i_amountToFuel) 
        {
            m_currentAmountOfEnergyType += i_amountToFuel;
        }

    }
}
