using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Fedotov.Game
{
    interface IUnit
    {
        bool FlagLive { get; set; }
        int Health { get; set; }
        int PositionX { get; set; }
        int PositionY { get; set; }
        int PositionZ { get; set; }
    }
}
