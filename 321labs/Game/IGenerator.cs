using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    interface IGenerator
    {
        int EnergyProduction { get; }
        void Generate();
    }
}
