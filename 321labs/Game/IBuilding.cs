﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    interface IBuilding : IUnit
    {
        bool IsDisabled { get; }
        int EnergyConsumption { get; }
        bool IsDestroed { get; }
        void Consume();
        void Switch();
    }
}
