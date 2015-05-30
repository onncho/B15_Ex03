using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{

    /// <summary>
    /// maybe we need to delete it
    /// </summary>
    class FuelEngine : Engine
    {
        FuelType m_fuelType;

        public FuelEngine(FuelType i_fuelType, float i_currentAmountFuel, float i_maxAmountOfFuel)
            : base(i_maxAmountOfFuel, i_currentAmountFuel, i_fuelType)
        {
            m_fuelType = i_fuelType;
        }

        public override bool fuelUpEnergy(FuelType i_fuelType, float i_amountToFuel)
        {
            bool operationSucceedded = i_fuelType == m_fuelType ? base.fuelUpEnergy(i_amountToFuel) : false;
            return operationSucceedded;
        }
    }
}
