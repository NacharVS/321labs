using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Fedotov.Game
{
    interface IMove
    {
        int speedMove { get; set; }
        int agilityMove { get; set; }

        void StopMove();
        void StartMove();
    }
}
