using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Fedotov.Game
{
    interface IFlight
    {
        int speedFlight { get; set; }
        int agilityFlight { get; set; }
        int hightFlight { get; set; }

        void StopFlight();
        void StartFlight();
    }
}
