using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class FuelSystem : Engine
    {
        enum FuelType { Soler, Octan95, Octan96, Octan98 };

        FuelType m_fuelType;

        public FuelSystem(FuelType i_fuelType, float i_currentAmountFuel, float i_maxAmountOfFuel)
            : base(i_maxAmountOfFuel, i_currentAmountFuel)
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
