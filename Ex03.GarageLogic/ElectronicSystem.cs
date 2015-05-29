using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class ElectronicSystem : Engine
    {

        public ElectronicSystem(float i_batteryMaxLifeTime, float i_batteryCurrentTimeLeft) : base(i_batteryMaxLifeTime, i_batteryCurrentTimeLeft) { }
    }
}
