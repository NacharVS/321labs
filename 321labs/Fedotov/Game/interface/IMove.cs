using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Fedotov.Game
{
    interface IMove
    {
        int SpeedMove { get; set; }
        int AgilityMove { get; set; }

        void StopMove();
        void StartMove();
    }
}
