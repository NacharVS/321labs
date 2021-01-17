using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game.inteface
{
    interface Iunit
    {
        int Health { get; set; }
        int PositionX { get; set; }
        int PositionY { get; set; }
        int PositionZ { get; set; }
        int armor { get; set; }
    }
}
