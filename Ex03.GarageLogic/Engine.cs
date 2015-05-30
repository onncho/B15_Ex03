using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public enum FuelType
    {
        Soler,
        Octan95,
        Octan96,
        Octan98,
        Electric
    }

    class Engine
    {
        
        FuelType m_fuelType;

        private float m_maxAmountOfEnergyType,
                      m_currentAmountOfEnergyType;
        

        public Engine(float i_maxAmount, float i_currentAmount, FuelType i_fuelType) 
        {
            m_maxAmountOfEnergyType = i_maxAmount;
            m_currentAmountOfEnergyType = i_currentAmount;
            m_fuelType = i_fuelType;
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

        public float maxAmountOfEnergy
        {
            get { return m_maxAmountOfEnergyType; }
            set { m_maxAmountOfEnergyType = value; }
        }

        public float currentAmountOfEnergy
        {
            get { return m_currentAmountOfEnergyType; }
        }

    }
}
