using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Fedotov.Game
{
    interface IFlight
    {
        int SpeedFlight { get; set; }
        int AgilityFlight { get; set; }
        int HightFlight { get; set; }

        void StopFlight();
        void StartFlight();
    }
}
