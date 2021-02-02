using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Fedotov.Game
{
    interface IUnit
    {
        string NickName { get; set; }
        Guid id { get; set; }
        bool FlagLive { get; set; }
        int Health { get; set; }
        int PositionX { get; set; }
        int PositionY { get; set; }
        int PositionZ { get; set; }
    }
}
